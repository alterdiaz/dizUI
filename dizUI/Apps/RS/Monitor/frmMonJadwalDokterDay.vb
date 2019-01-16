Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonJadwalDokterDay
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


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        gvData.ViewCaption = ""
        deTanggal.EditValue = nowTime
        deTanggal.Properties.MinValue = nowTime.AddDays(-30)
        deTanggal.Properties.MaxValue = nowTime.AddDays(30)
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
        sqls.DMLQuery("select 0 as jmlapp,sp.idparamedisspesialis,yan.pelayanan,isnull(jp.idjadwalparamedis,-1) as idjadwalparamedis,sp.idparamedis,p.nama as paramedis,s.nama as spesialis,pj.idjadwalsesi,js.nama as jadwalsesi,left(convert(varchar,pj.jammulai,108),5)+ ' - ' +left(convert(varchar,pj.jamselesai,108),5) as jadwalasal,isnull(convert(varchar,pj.jammulai,108),'00:00:00') as jammulai,isnull(convert(varchar,pj.jamselesai,108),'00:00:00') as jamselesai,isnull(left(convert(varchar,jp.jammulaipengganti,108),5)+ ' - ' +left(convert(varchar,jp.jamselesaipengganti,108),5),'Belum Ada') as jadwalpengganti,isnull(jp.idparamedispengganti,0) as idparamedispengganti,isnull(pp.nama,'Belum Ada') as paramedispengganti,isnull(convert(varchar,jp.jammulaipengganti,108),'00:00:00') as jammulaipengganti,isnull(convert(varchar,jp.jamselesaipengganti,108),'00:00:00') as jamselesaipengganti,cu.username as createdby,convert(varchar,pj.createddate,105)+' '+convert(varchar,pj.createddate,108) as createddate,isnull(uu.username,'-') as updatedby,isnull(convert(varchar,jp.updateddate,105)+' '+convert(varchar,jp.updateddate,108),'-') as updateddate from paramedisjadwal pj left join paramedisspesialis sp on pj.idparamedisspesialis=sp.idparamedisspesialis left join paramedis p on sp.idparamedis=p.idparamedis left join spesialis s on sp.idspesialis=s.idspesialis left join pelayananspesialis ps on s.idspesialis=ps.idspesialis left join pelayanan yan on yan.idpelayanan=ps.idpelayanan left join jadwalsesi js on pj.idjadwalsesi=js.idjadwalsesi left join jadwalparamedis jp on sp.idparamedis=jp.idparamedis and convert(varchar,jp.jadwaltanggal,105)='" & Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") & "' and jp.isdeleted=0  left join paramedis pp on jp.idparamedispengganti=pp.idparamedis left join sys_user cu on pj.createdby=cu.iduser left join sys_user uu on jp.updatedby=uu.iduser where pj.hari like ('%" & CDate(deTanggal.EditValue).DayOfWeek & "%') and pj.isdeleted=0 order by p.nama asc,s.nama asc,js.nama asc", "jp")

        If sqls.getDataSet("jp") = 0 Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = "Jadwal & Appointment Dokter"
        Else
            gcData.DataSource = sqls.dataTable("jp")

            For i As Integer = 0 To gvData.RowCount - 1
                Dim dr As DataRow = gvData.GetDataRow(i)
                Dim idjs As String = dr("idjadwalsesi")
                Dim idday As Long = CDate(deTanggal.EditValue).DayOfWeek
                Dim iddoktersp As String = dr("idparamedisspesialis")
                Dim day As Date = CDate(deTanggal.EditValue)

                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@tanggal", "@paramedis", "@sesi"})
                value.AddRange(New Object() {day, iddoktersp, idjs})
                Dim sqls2 As New SQLs(dbstring)
                sqls2.CallSP("spMonAppointment", "app", field, value)
                If sqls2.getDataSet("app") > 0 Then
                    dr("jmlapp") = sqls2.getDataSet("app")
                Else
                    dr("jmlapp") = 0
                End If
            Next
            GridColumn9.GroupIndex = 1
            gvData.ExpandAllGroups()
            gvData.BestFitColumns()
            gvData.ViewCaption = "Jadwal & Appointment Dokter - " & Format(CDate(deTanggal.EditValue), "dd ") & NamaBulan(CDate(deTanggal.EditValue).Month) & Format(CDate(deTanggal.EditValue), " yyyy")
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class