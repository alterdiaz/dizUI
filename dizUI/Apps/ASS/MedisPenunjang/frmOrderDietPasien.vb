Public Class frmOrderDietPasien
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

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select idparamedis as id,nama as content from paramedis where paramedistype in (2,3,4,5) and isdeleted=0 order by nama", "tmp")
        lueParamedis.Properties.DataSource = sqls.dataTable("tmp")
        lueParamedis.Properties.ValueMember = "id"
        lueParamedis.Properties.DisplayMember = "content"
        lueParamedis.EditValue = Nothing

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=1", "dm")
        clbcDiet.DataSource = sqls.dataTable("dm")
        clbcDiet.ValueMember = "iddietmenu"
        clbcDiet.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=2", "jm")
        clbcMakanan.DataSource = sqls.dataTable("jm")
        clbcMakanan.ValueMember = "iddietmenu"
        clbcMakanan.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=3", "jb")
        clbcBuah.DataSource = sqls.dataTable("jb")
        clbcBuah.ValueMember = "iddietmenu"
        clbcBuah.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=4", "ja")
        clbcAlergi.DataSource = sqls.dataTable("ja")
        clbcAlergi.ValueMember = "iddietmenu"
        clbcAlergi.DisplayMember = "dietmenu"

        sqls.DMLQuery("select iddietmenu,dietmenu from dietmenu dm where diettype=5", "tm")
        clbcTidakMakan.DataSource = sqls.dataTable("tm")
        clbcTidakMakan.ValueMember = "iddietmenu"
        clbcTidakMakan.DisplayMember = "dietmenu"
    End Sub

    Private Sub frmOrderDietPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
    End Sub

    Private Sub btnDietMenu_Click(sender As Object, e As EventArgs) Handles btnDietMenu.Click
        formTitle = "Diet Menu"
        Dim frmMon As New frmDietMenu
        tambahChild(frmMon)
        frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub kosongkanIsian()
        teNomor.EditValue = "XXXX/XXX/ODP/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teTanggal.EditValue = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

        deDatang.EditValue = nowTime
        meAdvis.EditValue = ""
        lueParamedis.EditValue = Nothing

        For index As Integer = 0 To clbcDiet.Items.Count - 1
            clbcDiet.SetItemChecked(index, False)
        Next
        For index As Integer = 0 To clbcBuah.Items.Count - 1
            clbcBuah.SetItemChecked(index, False)
        Next
        For index As Integer = 0 To clbcAlergi.Items.Count - 1
            clbcAlergi.SetItemChecked(index, False)
        Next
        For index As Integer = 0 To clbcMakanan.Items.Count - 1
            clbcMakanan.SetItemChecked(index, False)
        Next
        For index As Integer = 0 To clbcTidakMakan.Items.Count - 1
            clbcTidakMakan.SetItemChecked(index, False)
        Next
        deDatang.Properties.ReadOnly = True
    End Sub

    Private ordertype As String = ""
    Private noreg As String = ""
    Private idreg As String = "-1"

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadLOV()
        Me.kosongkanIsian()
        modCore.kosongkanIsian(tlpRegistrasi)
        modCore.kosongkanIsian(tlpPasien)
        modCore.kosongkanIsian(tlpAlamat)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where rm.rekammedisno<>0 and r.iddepartment in (select [value] from sys_appsetting where variable in('idirnadept','idicudept','idiccudept','idhcudept','idpicudept','idvkdept','idodsdept')) order by r.registrasidate desc", "search")
        Dim cari As New frmSearchTanggal(sqls.dataSet, "search", "idregistrasi", "Tgl Registrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselect As String = cari.GetIDSelectData

            sqls.DMLQuery("select r.remarks,r.isoneday,r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselect & "'", "getidrm")
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
            sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

            teNoRegistrasi.Tag = idselect
            noreg = sqls.getDataSet("getidrm", 0, "registrasino")

            idreg = idselect
            teTanggalRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasidate")

            teNoRM.Text = sqls.getDataSet("registrasi", 0, "rekammedisno")
            teJenisKartu.Text = sqls.getDataSet("registrasi", 0, "jeniskartu")
            teNomorKartu.Text = sqls.getDataSet("registrasi", 0, "nomorkartu")
            teHamil.Text = sqls.getDataSet("getidrm", 0, "hamil")
            teGolonganDarah.Text = sqls.getDataSet("registrasi", 0, "golongandarah")
            teRhesus.Text = sqls.getDataSet("registrasi", 0, "rhesus")

            teNoRM.Tag = sqls.getDataSet("registrasi", 0, "idrekammedis")
            teNamaPanggilan.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
            teNama.Text = sqls.getDataSet("registrasi", 0, "nama")
            teJenisKelamin.Text = sqls.getDataSet("registrasi", 0, "jeniskelamin")
            teJenisKelamin.Tag = sqls.getDataSet("registrasi", 0, "idjeniskelamin")

            teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
            teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
            teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")
            meAlamat.EditValue = sqls.getDataSet("registrasi", 0, "alamat")

            teTanggal.EditValue = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teNomor.EditValue = ""
        End If
    End Sub

End Class