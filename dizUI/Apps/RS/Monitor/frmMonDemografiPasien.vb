Public Class frmMonDemografiPasien
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

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueWilayah.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If lueWilayah.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = ""
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        If lueWilayah.EditValue = 1 Then
            sqls.DMLQuery("select 0 as nomor,count(a.idnegara) as counter,n.wilayah as wilayah from alamat a left join rekammedis rm on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' left join wilayah n on n.idwilayah=a.idnegara left join registrasi r on r.idrekammedis=rm.idrekammedis where MONTH(r.registrasidate)='" & CDate(deTanggal.EditValue).Month & "' and year(r.registrasidate)='" & CDate(deTanggal.EditValue).Year & "' and rm.rekammedisno<>0 group by n.wilayah ", "demografi")
        ElseIf lueWilayah.EditValue = 2 Then
            sqls.DMLQuery("select 0 as nomor,count(a.idnegara) as counter,(n.wilayah+','+isnull(p.wilayah,'')) as wilayah from alamat a left join rekammedis rm on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' left join wilayah n on n.idwilayah=a.idnegara left join wilayah p on p.idwilayah=a.idpropinsi left join registrasi r on r.idrekammedis=rm.idrekammedis where MONTH(r.registrasidate)='" & CDate(deTanggal.EditValue).Month & "' and year(r.registrasidate)='" & CDate(deTanggal.EditValue).Year & "' and rm.rekammedisno<>0 group by (n.wilayah+','+isnull(p.wilayah,'')) ", "demografi")
        ElseIf lueWilayah.EditValue = 3 Then
            sqls.DMLQuery("select 0 as nomor,count(a.idnegara) as counter,(n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')) as wilayah from alamat a left join rekammedis rm on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' left join wilayah n on n.idwilayah=a.idnegara left join wilayah p on p.idwilayah=a.idpropinsi left join wilayah b on b.idwilayah=a.idkabupaten left join registrasi r on r.idrekammedis=rm.idrekammedis where MONTH(r.registrasidate)='" & CDate(deTanggal.EditValue).Month & "' and year(r.registrasidate)='" & CDate(deTanggal.EditValue).Year & "' and rm.rekammedisno<>0 group by (n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')) ", "demografi")
        ElseIf lueWilayah.EditValue = 4 Then
            sqls.DMLQuery("select 0 as nomor,count(a.idnegara) as counter,(n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')+','+isnull(c.wilayah,'')) as wilayah from alamat a left join rekammedis rm on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' left join wilayah n on n.idwilayah=a.idnegara left join wilayah p on p.idwilayah=a.idpropinsi left join wilayah b on b.idwilayah=a.idkabupaten left join wilayah c on c.idwilayah=a.idkecamatan left join registrasi r on r.idrekammedis=rm.idrekammedis where MONTH(r.registrasidate)='" & CDate(deTanggal.EditValue).Month & "' and year(r.registrasidate)='" & CDate(deTanggal.EditValue).Year & "' and rm.rekammedisno<>0 group by (n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')+','+isnull(c.wilayah,'')) ", "demografi")
        ElseIf lueWilayah.EditValue = 5 Then
            sqls.DMLQuery("select 0 as nomor,count(a.idnegara) as counter,(n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')+','+isnull(c.wilayah,'')+','+isnull(l.wilayah,'')) as wilayah from alamat a left join rekammedis rm on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' left join wilayah n on n.idwilayah=a.idnegara left join wilayah p on p.idwilayah=a.idpropinsi left join wilayah b on b.idwilayah=a.idkabupaten left join wilayah c on c.idwilayah=a.idkecamatan left join wilayah l on l.idwilayah=a.idkelurahan left join registrasi r on r.idrekammedis=rm.idrekammedis where MONTH(r.registrasidate)='" & CDate(deTanggal.EditValue).Month & "' and year(r.registrasidate)='" & CDate(deTanggal.EditValue).Year & "' and rm.rekammedisno<>0 group by (n.wilayah+','+isnull(p.wilayah,'')+','+isnull(b.wilayah,'')+','+isnull(c.wilayah,'')+','+isnull(l.wilayah,'')) ", "demografi")
        End If

        gcData.DataSource = sqls.dataTable("demografi")
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, GridColumn1, i + 1)
        Next
        gvData.BestFitColumns()
        gvData.ViewCaption = "Demografi Pasien per " & lueWilayah.Text & " - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        deTanggal.EditValue = Nothing
        gvData.ViewCaption = ""
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LEVELAREA' and idgeneral not in(6,7) order by idgeneral asc", "wilayah")
        lueWilayah.Properties.DataSource = sqls.dataTable("wilayah")
        lueWilayah.Properties.ValueMember = "id"
        lueWilayah.Properties.DisplayMember = "content"
        lueWilayah.EditValue = Nothing
        If sqls.getDataSet("wilayah") = 0 Then
            dizMsgbox("Jenis Wilayah tidak ditemukan" & vbCrLf & "Jenis Wilayah harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class