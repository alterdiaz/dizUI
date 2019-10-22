Public Class frmPenyusutanMon
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

    Private Sub frmPenyusutanMon_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = nowTime
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = ""
            Exit Sub
        End If

        Dim tahun As Integer = CDate(deTanggal.EditValue).Year

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ROW_NUMBER() OVER (order by p.perolehandate asc) as nomor,p.idpenyusutan,convert(varchar,p.perolehandate,105) as perolehandate,i.item, p.qty, p.hargasatuan,p.masapakai,p.subtotal, p.subtotal-isnull(bef.subtotal,0) as saldoawal,ex.subtotal as saldopenyusutan,p.subtotal-(isnull(bef.subtotal,0)+isnull(ex.subtotal,0)) as saldoakhir,isnull(jan.jumlahuang,0) as jan,isnull(feb.jumlahuang,0) as feb,isnull(mar.jumlahuang,0) as mar,isnull(apr.jumlahuang,0) as apr,isnull(mei.jumlahuang,0) as mei,isnull(jun.jumlahuang,0) as jun,isnull(jul.jumlahuang,0) as jul,isnull(agus.jumlahuang,0) as agus,isnull(sept.jumlahuang,0) as sept,isnull(okt.jumlahuang,0) as okt,isnull(nov.jumlahuang,0) as nov,isnull(des.jumlahuang,0) as des from penyusutan p left join (select distinct idpenyusutan from penyusutandt where year(penyusutandate)=" & tahun & ") d on d.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,sum(jumlahuang) as subtotal from penyusutandt where year(penyusutandate)=" & tahun & " group by idpenyusutan) ex on p.idpenyusutan=ex.idpenyusutan left join (select idpenyusutan,sum(jumlahuang) as subtotal from penyusutandt where year(penyusutandate)<" & tahun & " group by idpenyusutan) bef on p.idpenyusutan=bef.idpenyusutan left join item i on p.iditem=i.iditem left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=1) jan on jan.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=2) feb on feb.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=3) mar on mar.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=4) apr on apr.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=5) mei on mei.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=6) jun on jun.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=7) jul on jul.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=8) agus on agus.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=9) sept on sept.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=10) okt on okt.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=11) nov on nov.idpenyusutan=p.idpenyusutan left join (select idpenyusutan,jumlahuang from penyusutandt where year(penyusutandate)=" & tahun & " and month(penyusutandate)=12) des on des.idpenyusutan=p.idpenyusutan order by p.perolehandate asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Penyusutan - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

End Class