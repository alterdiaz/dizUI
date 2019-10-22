Public Class frmRMHistory
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

    Private Sub frmRMHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
    End Sub

    Private idrm As String = ""
    Private Sub kosongkanisian()
        idrm = ""
        teNoRM.Text = "0"
        teNama.EditValue = Nothing
        teJenisKelamin.EditValue = Nothing
        teTglLahir.EditValue = Nothing
        gvData.ViewCaption = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        Dim strQuery As String = "select r.idrekammedis as 'ID',del.generalcode as 'Status Data',dbo.fformatnorm(r.rekammedisno) as 'No RM',sap.generalcode + ' ' + r.nama as 'Nama Pasien',st.generalcode as 'Jenis Kelamin',w.wilayah as 'Warganegara',kot.wilayah as 'Tempat Lahir',convert(varchar,r.tanggallahir,105) as 'Tgl Lahir',ms.generalcode as 'Status Pernikahan',isnull(a.alamat,'-') as 'Alamat',isnull(telk.phone,convert(varchar,0)) + ' ext. ' + isnull(telk.extension,convert(varchar,0)) as 'Telp Kantor',isnull(telr.phone,0) as 'Telp Rumah',isnull(telh.phone,0) as 'Handphone' from rekammedis r left join sys_generalcode sap on r.sapaan=sap.idgeneral and sap.gctype='SAPAAN' left join sys_generalcode st on r.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' left join sys_generalcode ms on r.pernikahan=ms.idgeneral and ms.gctype='MARITALSTATUS' left join alamat a on r.idrekammedis=a.idreff and a.tablereff='PASIEN'and a.isprimary=1 and a.isdeleted=0 left join wilayah w on r.kewarganegaraan=w.idwilayah left join wilayah kot on r.kotalahir=kot.idwilayah left join phone telk on r.idrekammedis=telk.idreff and telk.tablereff='PASIEN' and telk.isprimary=1 and telk.isdeleted=0 and telk.phonetype=1 left join phone telr on r.idrekammedis=telr.idreff and telr.tablereff='PASIEN' and telr.isprimary=1 and telr.isdeleted=0 and telr.phonetype=2 left join phone telh on r.idrekammedis=telh.idreff and telh.tablereff='PASIEN' and telh.isprimary=1 and telh.isdeleted=0 and telh.phonetype=3 left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='delete' where r.rekammedisno<>0 and (r.nama like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%') order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")
        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrm = cari.GetIDSelectData
            sqls.DMLQuery("select rm.isdeleted,rm.rekammedisno,rm.nama,rm.jeniskelamin,st.generalcode as sextype,convert(varchar,rm.tanggallahir,105) as tanggallahir,rm.idlokasiasal,l.nama as lokasiasal,rm.idlokasiskrg,ls.nama as lokasiskrg from rekammedis rm left join lokasi l on rm.idlokasiasal=l.idlokasi left join lokasi ls on rm.idlokasiskrg=ls.idlokasi left join sys_generalcode st on rm.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' where rm.idrekammedis='" & idrm & "'", "lama")
            teNoRM.Text = Format(CLng(sqls.getDataSet("lama", 0, "rekammedisno")), "0#######")
            teNama.Text = sqls.getDataSet("lama", 0, "nama")
            teJenisKelamin.Text = sqls.getDataSet("lama", 0, "sextype")
            teTglLahir.Text = sqls.getDataSet("lama", 0, "tanggallahir")

            btn10_Click(btn10, Nothing)
        End If
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If idrm = "" Then Exit Sub

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {idrm})
        sqls.CallSP("spHistoriRM10", "trace", field, value)
        gcData.DataSource = sqls.dataTable("trace")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Mutasi Berkas RM " & teNoRM.Text
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        If idrm = "" Then Exit Sub

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {idrm})
        sqls.CallSP("spHistoriRM25", "trace", field, value)
        gcData.DataSource = sqls.dataTable("trace")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Mutasi Berkas RM " & teNoRM.Text
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        If idrm = "" Then Exit Sub

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {idrm})
        sqls.CallSP("spHistoriRM50", "trace", field, value)
        gcData.DataSource = sqls.dataTable("trace")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Mutasi Berkas RM " & teNoRM.Text
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btnSemua.Click
        If idrm = "" Then Exit Sub

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqls As New SQLs(dbstring)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {idrm})
        sqls.CallSP("spHistoriRMAll", "trace", field, value)
        gcData.DataSource = sqls.dataTable("trace")
        gvData.BestFitColumns()
        gvData.ViewCaption = "Mutasi Berkas RM " & teNoRM.Text
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gcData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class