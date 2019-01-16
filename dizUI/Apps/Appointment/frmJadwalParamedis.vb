Imports DevExpress.XtraGrid.Views.Base

Public Class frmJadwalParamedis
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
        mysqls.DMLQuery("select idparamedis as id,nama as content from paramedis where isdeleted=0 order by nama asc", "pengganti")
        luePengganti.Properties.DataSource = mysqls.dataTable("pengganti")
        luePengganti.Properties.DisplayMember = "content"
        luePengganti.Properties.ValueMember = "id"
        If mysqls.getDataSet("pengganti") = 0 Then
            dizMsgbox("Dokter Pengganti tidak ditemukan" & vbCrLf & "Dokter Pengganti harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private jenisPelayanan As String = ""
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.MinValue = nowTime
        deTanggal.Properties.MaxValue = nowTime.AddDays(30)
        loadLOV()

        gvData.ViewCaption = ""
        tlpJadwal2.Visible = False
        teParamedis.Text = ""
        teSpesialis.Text = ""
        teSesi.Text = ""
        teJadwalAsal.Text = ""
        luePengganti.EditValue = Nothing
        teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select isnull(jp.idjadwalparamedis,-1) as idjadwalparamedis,sp.idparamedis,p.nama as paramedis,s.nama as spesialis,jp.idjadwalsesi,js.nama as jadwalsesi,left(convert(varchar,pj.jammulai,108),5)+ ' - ' +left(convert(varchar,pj.jamselesai,108),5) as jadwalasal,isnull(convert(varchar,pj.jammulai,108),'00:00:00') as jammulai,isnull(convert(varchar,pj.jamselesai,108),'00:00:00') as jamselesai,isnull(left(convert(varchar,jp.jammulaipengganti,108),5)+ ' - ' +left(convert(varchar,jp.jamselesaipengganti,108),5),'Belum Ada') as jadwalpengganti,isnull(jp.idparamedispengganti,0) as idparamedispengganti,isnull(pp.nama,'Belum Ada') as paramedispengganti,isnull(convert(varchar,jp.jammulaipengganti,108),'00:00:00') as jammulaipengganti,isnull(convert(varchar,jp.jamselesaipengganti,108),'00:00:00') as jamselesaipengganti,cu.username as createdby,convert(varchar,pj.createddate,105)+' '+convert(varchar,pj.createddate,108) as createddate,isnull(uu.username,'-') as updatedby,isnull(convert(varchar,jp.updateddate,105)+' '+convert(varchar,jp.updateddate,108),'-') as updateddate from paramedisjadwal pj left join paramedisspesialis sp on pj.idparamedisspesialis=sp.idparamedisspesialis left join paramedis p on sp.idparamedis=p.idparamedis left join spesialis s on sp.idspesialis=s.idspesialis left join jadwalsesi js on pj.idjadwalsesi=js.idjadwalsesi left join jadwalparamedis jp on sp.idparamedis=jp.idparamedis and convert(varchar,jp.jadwaltanggal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' and jp.isdeleted=0  left join paramedis pp on jp.idparamedispengganti=pp.idparamedis left join sys_user cu on pj.createdby=cu.iduser left join sys_user uu on jp.updatedby=uu.iduser where pj.hari like ('%" & CDate(deTanggal.EditValue).DayOfWeek & "%') and pj.isdeleted=0 order by p.nama asc,s.nama asc,js.nama asc", "jp")
        If sqls.getDataSet("jp") = 0 Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = "Jadwal Dokter"
        Else
            gcData.DataSource = sqls.dataTable("jp")
            gvData.BestFitColumns()
            gvData.ViewCaption = "Jadwal Dokter - " & Format(CDate(deTanggal.EditValue), "dd ") & NamaBulan(CDate(deTanggal.EditValue).Month) & Format(CDate(deTanggal.EditValue), " yyyy")

            tlpJadwal2.Visible = False

            teParamedis.Text = ""
            teSpesialis.Text = ""
            teSesi.Text = ""
            teJadwalAsal.Text = ""
            luePengganti.EditValue = Nothing
            teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If gvData.FocusedRowHandle < 0 Then
            tlpJadwal2.Visible = False

            teParamedis.Text = ""
            teSpesialis.Text = ""
            teSesi.Text = ""
            teJadwalAsal.Text = ""
            luePengganti.EditValue = Nothing
            teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        Else
            tlpJadwal2.Visible = True

            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            idData = dcol("idjadwalparamedis")
            teParamedis.Text = dcol("paramedis")
            teParamedis.Tag = dcol("idparamedis")
            teSpesialis.Text = dcol("spesialis")
            teSesi.Text = dcol("jadwalsesi")
            teSesi.Tag = dcol("idjadwalsesi")
            teJadwalAsal.Text = dcol("jadwalasal")
            teJamMulai.Tag = dcol("jammulai")
            teJamSelesai.Tag = dcol("jamselesai")

            If dcol("idparamedispengganti") = -1 Then
                luePengganti.EditValue = Nothing
            Else
                luePengganti.EditValue = dcol("idparamedispengganti")
            End If
            If dcol("jammulaipengganti") = "00:00:00" Then
                teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            Else
                teJamMulai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jammulaipengganti").ToString.Split(":")(0), dcol("jammulaipengganti").ToString.Split(":")(1), 0)
            End If
            If dcol("jamselesaipengganti") = "00:00:00" Then
                teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            Else
                teJamSelesai.EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jamselesaipengganti").ToString.Split(":")(0), dcol("jamselesaipengganti").ToString.Split(":")(1), 0)
            End If
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
        If teJamMulai.Text = "00:00" Then
            bentry = False
        End If
        If teJamSelesai.Text = "00:00" Then
            bentry = False
        End If
        If CDate(teJamMulai.EditValue) > CDate(teJamSelesai.EditValue) Then
            bentry = False
        End If
        If bentry = False Then
            dizMsgbox("Data Jadwal belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        Dim jammulai As Date = New Date(nowTime.Year, nowTime.Month, nowTime.Day, teJamMulai.Tag.ToString.Split(":")(0), teJamMulai.Tag.ToString.Split(":")(1), 0)
        Dim jamselesai As Date = New Date(nowTime.Year, nowTime.Month, nowTime.Day, teJamSelesai.Tag.ToString.Split(":")(0), teJamSelesai.Tag.ToString.Split(":")(1), 0)
        Dim jammulaip As Date = New Date(nowTime.Year, nowTime.Month, nowTime.Day, CDate(teJamMulai.EditValue).Hour, CDate(teJamMulai.EditValue).Minute, 0)
        Dim jamselesaip As Date = New Date(nowTime.Year, nowTime.Month, nowTime.Day, CDate(teJamSelesai.EditValue).Hour, CDate(teJamSelesai.EditValue).Minute, 0)

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        idData = GenerateGUID()
        field.AddRange(New String() {"idjadwalparamedis", "idparamedis", "idparamedispengganti", "idjadwalsesi", "idlokasi", "idlokasipengganti", "jadwaltanggal", "jammulai", "jamselesai", "jammulaipengganti", "jamselesaipengganti", "createdby", "idcompany"})
        value.AddRange(New Object() {idData, teParamedis.Tag, If(luePengganti.EditValue, 0), teSesi.Tag, 0, 0, CDate(deTanggal.EditValue), jammulai.TimeOfDay, jamselesai.TimeOfDay, jammulaip.TimeOfDay, jamselesaip.TimeOfDay, userid, idcomp})
        If dtsql.datasetSave("jadwalparamedis", idData, field, value, False) = True Then
            dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
        End If
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnClearPengganti_Click(sender As Object, e As EventArgs) Handles btnClearPengganti.Click
        luePengganti.EditValue = Nothing
    End Sub

End Class