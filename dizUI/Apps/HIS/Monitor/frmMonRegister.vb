Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonRegister
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

    Private strdept As String = ""
    Private strquery As String = "select ROW_NUMBER() OVER (Order by r.registrasidate asc) as nomor, r.idregistrasi, convert(varchar,r.registrasidate,105)+ ' '+convert(varchar,r.registrasidate,108) as regdate, ur.username as regby, convert(varchar,r.prepareddate,105)+ ' '+convert(varchar,r.prepareddate,108) as prepdate, dbo.fumurdetik(r.registrasidate,r.prepareddate) as preptime, case when r.preparedby is null then 'Belum Direspon RM' else convert(varchar,r.prepareddate,105)+ ' '+convert(varchar,r.prepareddate,108) + char(13) + char(10) + dbo.fumurdetik(r.registrasidate,r.prepareddate) + ' - ' + up.username end as prepnote, up.username as prepby, convert(varchar,r.receiveddate,105)+ ' '+convert(varchar,r.receiveddate,108) as recvdate, dbo.fumurdetik(r.prepareddate,r.receiveddate) as recvtime, case when r.receiveddate is null then 'Belum Direspon Unit' else convert(varchar,r.receiveddate,105)+ ' '+convert(varchar,r.receiveddate,108) + char(13) + char(10) + dbo.fumurdetik(r.prepareddate,r.receiveddate) + ' - ' + uv.username end as recvnote, uv.username as recvby, case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as regno, case when rm.rekammedisno<>0 then dbo.fFormatNoRM(rm.rekammedisno) when rm.rekammedisno=0 then 'A P S' end as norm, rm.nama, jk.generalcode as jeniskelamin, convert(varchar,rm.tanggallahir,105) as tanggallahir, dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as umur, isnull(a.alamat,'-') as alamat, isnull(n.wilayah,'-') as negara, isnull(p.wilayah,'-') as propinsi, isnull(b.wilayah,'-') as kabupaten, isnull(c.wilayah,'-') as kecamatan, isnull(l.wilayah,'-') as kelurahan, ap1.generalcode as asalpx, case when r.asalpx=2 then apd.generalcode when r.asalpx=1 then apr.generalcode end as asalpx2, case when r.asalpx=1 and r.asalpx2=1 then parr.nama when r.asalpx=1 and r.asalpx2=2 then bp.nama else '-' end as asalrujukan, parm.nama as dokterruangan, isnull(spe.nama,'-') as spesialisruangan, u.unit, dept.department, case when r.kunjunganke=1 then 'Baru' else 'Lama' end as kunjungan, r.remarks, sr.generalcode as regstatus from registrasi r left join sys_generalcode sr on r.registrasistatus=sr.idgeneral and sr.gctype='REGSTATUS' left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join alamat a on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' and a.isprimary=1 left join wilayah n on a.idnegara=n.idwilayah left join wilayah p on a.idpropinsi=p.idwilayah left join wilayah b on a.idkabupaten=b.idwilayah left join wilayah c on a.idkecamatan=c.idwilayah left join wilayah l on a.idkelurahan=l.idwilayah left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join sys_generalcode ap1 on r.asalpx=ap1.idgeneral and ap1.gctype='ASALPX' left join sys_generalcode apd on r.asalpx2=apd.idgeneral and apd.gctype='ASALPXDTG' left join sys_generalcode apr on r.asalpx2=apr.idgeneral and apr.gctype='ASALPXRUJ' left join businesspartner bp on r.asalrujukan=bp.idbusinesspartner left join paramedis parr on r.asalrujukan=parr.idparamedis left join paramedis parm on r.iddokterruangan=parm.idparamedis left join spesialis spe on r.idspesialisruangan=spe.idspesialis left join department dept on r.iddepartment=dept.iddepartment left join unit u on r.idunit=u.idunit left join sys_user ur on r.createdby=ur.iduser left join sys_user up on r.preparedby=up.iduser left join sys_user uv on r.receivedby=uv.iduser where r.isdeleted=0 and year(r.registrasidate)=#tahun# and month(r.registrasidate)=#bulan# and day(r.registrasidate)=#tanggal# and r.iddepartment in (#dept#) order by r.registrasidate desc"

    Private Sub loadgrid()
        'Dim loadScr As New frmLoading()
        'splashClosed = False
        '    loadScr.Show(Me)
        '    loadScr.BringToFront()
        '    Application.DoEvents()
        '    Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim tmpstr As String = ""
        tmpstr = strquery.Replace("#tahun#", CDate(deTanggal.EditValue).Year)
        tmpstr = tmpstr.Replace("#bulan#", CDate(deTanggal.EditValue).Month)
        tmpstr = tmpstr.Replace("#tanggal#", CDate(deTanggal.EditValue).Day)
        If strdept = "" Then
            tmpstr = tmpstr.Replace("and r.iddepartment in (#dept#) ", "")
        Else
            tmpstr = tmpstr.Replace("#dept#", strdept)

        End If
        sqls.DMLQuery(tmpstr, "monreg")

        gvData.ViewCaption = "Registrasi Pasien - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year

        If sqls.getDataSet("monreg") = 0 Then
            gcData.DataSource = Nothing
        Else
            gcData.DataSource = sqls.dataTable("monreg")
        End If

        'Dim cnt As Long = 1
        'Dim paramname As String = ""
        'For i As Integer = 0 To sqls.dataTable("monreg").Rows.Count - 1
        '    Dim dr As DataRow = gvData.GetDataRow(i)
        '    If paramname <> dr("dokterruangan") Then
        '        cnt = 1
        '        paramname = dr("dokterruangan")
        '    End If
        '    gvData.SetRowCellValue(i, GridColumn1, cnt)
        '    cnt += 1
        'Next
        'GridColumn18.GroupIndex = 1
        'gvData.ExpandAllGroups()
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        loadgrid()
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
        gvData.ViewCaption = " "
        deTanggal.EditValue = nowTime
        Threading.Thread.Sleep(100)
        loadLOV()

        btnAuto_Click(btnAuto, Nothing)
        'btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim isauto As Boolean = False
        If btnAuto.Text = "MANUAL" Then
            isauto = True
            btnAuto_Click(btnAuto, Nothing)
        End If

        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If

        If isauto = True Then
            btnAuto_Click(btnAuto, Nothing)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cnt = 15
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment as id,kode as content from department where iddepartment in (select value from sys_appsetting where variable in ('IDHDDept','IDICUDept','IDVKDept','IDIRNADept','IDIRMDept','IDNICUDept','IDLabDept','IDCathDept','IDIRJDept','IDIBSDept','IDHCUDept','IDPICUDept','IDODSDept','IDRadDept','IDICCUDept','IDIGDDept','IDMCUDept') and value <>'0') order by department asc", "dept")
        cboDepartment.Properties.DataSource = sqls.dataTable("dept")
        cboDepartment.Properties.ValueMember = "id"
        cboDepartment.Properties.DisplayMember = "content"
    End Sub

    Private Sub cboDepartment_EditValueChanged(sender As Object, e As EventArgs) Handles cboDepartment.EditValueChanged
        strdept = ""
        If deTanggal.EditValue Is Nothing Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If
        If cboDepartment.EditValue = "" Then
            strdept = ""
        Else
            strdept = cboDepartment.EditValue.ToString.Replace(",", "','")
            strdept = "'" & strdept & "'"
        End If

        loadgrid()
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If btnAuto.Text = "AUTO REFRESH" Then
            cnt = 15
            lblRefresh.Text = "REFRESH " & cnt & " DETIK"
            tmrWaktu.Start()
            lblRefresh.Visible = True
            btnAuto.Text = "MANUAL"
        Else
            tmrWaktu.Stop()
            lblRefresh.Visible = False
            btnAuto.Text = "AUTO REFRESH"
        End If
    End Sub

    Private cnt As Integer = 15
    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        lblRefresh.Text = "REFRESH " & cnt & " DETIK"
        cnt -= 1
        If cnt = 0 Then
            cnt = 15
            btnRefresh_Click(btnRefresh, Nothing)
        End If
    End Sub

    Private idxFocus As Integer = -1
    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        If gvData.RowCount = 0 Then Exit Sub

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        idxFocus = view.FocusedRowHandle

        If idxFocus >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(idxFocus)
            Dim idreg As String = dr("idregistrasi")
            'Dim hl7 As New HL7SDK.Cda.

            If idreg <> "" Then
                tmrWaktu.Stop()
                Dim radsel10 As New frmSelectLabel10("")
                radsel10.bypass(idreg)
                radsel10.ShowDialog(Me)
                tmrWaktu.Start()
            End If
        End If
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        idxFocus = e.FocusedRowHandle
    End Sub

End Class