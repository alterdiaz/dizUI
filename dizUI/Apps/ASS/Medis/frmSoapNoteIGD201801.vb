Public Class frmSoapNoteIGD201801
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

    Private idd As Long = -1
    Private isstandalone As Long = 1
    Public Property id As Long
        Get
            Return idd
        End Get
        Set(value As Long)
            idd = value
            isstandalone = 0
        End Set
    End Property

    Private fromload As Boolean = True
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        pAnatomi.SendToBack()
        pAnatomi.Visible = False
        peAnatomi.Cursor = Cursors.Cross
        btnAnatomiClear.BringToFront()
        btnAnatomiExit.BringToFront()
        imgAnatomi = Nothing

        checkFieldMaxLength(dbstring, tlpSOAP, "soapnote")

        If fromload = True Then
            If idd = -1 Then
                isstandalone = 1
            End If
            If isstandalone = 1 Then
                btnSearch.Visible = True
                btnHistoriPasien.Visible = True
                btnInfoPasien.Visible = True
            Else
                btnSearch.Visible = False
                btnHistoriPasien.Visible = False
                btnInfoPasien.Visible = False
            End If
        End If
        fromload = False

        btnSearch_Click(Me, Nothing)
    End Sub

    Private mouseClicked As Boolean = False
    Private mousePos As Point
    Private sizeShape As Single = 50
    Private Sub peAnatomi_Paint(sender As Object, e As PaintEventArgs) Handles peAnatomi.Paint
        If mouseClicked Then
            If isClearImg = False Then
                If mousePos.X > 0 And mousePos.Y > 0 Then
                    Using bmp As New Bitmap(peAnatomi.Image) 'lets get the original image
                        Using g As Graphics = Graphics.FromImage(bmp)
                            DrawACircle(g, mousePos, 50)
                            'DrawACircle(e.Graphics, mousePos, 50)
                            peAnatomi.Image = CType(bmp.Clone, Image)
                        End Using
                    End Using
                End If
            Else
                peAnatomi.Image = Nothing
            End If
        End If
    End Sub

    Private Sub peAnatomi_MouseDown(sender As Object, e As MouseEventArgs) Handles peAnatomi.MouseDown
        mouseClicked = True
        mousePos = New Point(e.X, e.Y)
        peAnatomi.Invalidate()
    End Sub

    Private Sub peAnatomi_MouseUp(sender As Object, e As MouseEventArgs) Handles peAnatomi.MouseUp
        peAnatomi.Invalidate()
        isPoint = True
    End Sub

    Private Sub DrawACircle(ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)
        Dim pn As New Pen(Color.Red)
        pn.Width = 4
        Dim rect As New Rectangle(center.X - (radius / 2), center.Y - (radius / 2), radius, radius)
        g.DrawEllipse(pn, rect)
    End Sub

    Private isClearImg As Boolean = False
    Private isPoint As Boolean = False
    Private Sub btnAnatomiCLear_Click(sender As Object, e As EventArgs) Handles btnAnatomiClear.Click
        isClearImg = True
        peAnatomi.Image = Nothing
        peAnatomi.Invalidate()
        mousePos.X = 0
        mousePos.Y = 0
        Threading.Thread.Sleep(1000)
        peAnatomi.Image = imgAnatomi
        isClearImg = False
        isPoint = False
    End Sub

    Private Sub btnAnatomiExit_Click(sender As Object, e As EventArgs) Handles btnAnatomiExit.Click
        pAnatomi.SendToBack()
        pAnatomi.Visible = False
        tlpForm.Enabled = True
    End Sub

    Private Sub btnAnatomi_Click(sender As Object, e As EventArgs) Handles btnAnatomi.Click
        If imgAnatomi Is Nothing Then
            dizMsgbox("Belum memilih registrasi", dizMsgboxStyle.Info)
            Exit Sub
        End If
        pAnatomi.Visible = True
        pAnatomi.BringToFront()
        tlpForm.Enabled = False
    End Sub

    Private idasesmen As Long = -1
    Private idselect As Long = -1
    Private jenistransselect As String = ""
    Private idtransselect As Long = 0
    Private iddeptselect As Long = -1
    Private idunitselect As Long = -1
    Private formatstring As String = ""
    Private formatperiode As String = ""
    Private isFromLoad As Boolean = True
    Private imgAnatomi As Image = Nothing
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpSOAP)

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = ""
        teNoRM.Text = 0
        teTanggalPendaftaran.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        btnSave.Enabled = True
        btnSavePrint.Enabled = True
        statData = statusData.Baru
        If isstandalone = 1 Then
            idd = -1
        End If

        imgAnatomi = Nothing
        peAnatomi.Image = imgAnatomi
        idselect = -1
        iddeptselect = 0
        idunitselect = 0
        idtransselect = 0
        jenistransselect = ""
        formatstring = ""
        formatperiode = ""
        teNoSOAP.Text = "SOAP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

        Dim sqls As New SQLs(dbstring)
        If isstandalone = 1 Then
            sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept') order by r.registrasidate desc", "search")

            Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
            tambahChild(cari)
            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                idselect = CLng(cari.GetIDSelectData)
                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi=" & idselect, "getidrm")
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@idrm"})
                value.AddRange(New Object() {idselect})
                sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

                iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
                idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

                sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%SOAPNOTE%' and iddepartment=" & iddeptselect & " and idunit=" & idunitselect, "getidtrans")
                If sqls.getDataSet("getidtrans") > 0 Then
                    idtransselect = sqls.getDataSet("getidtrans", 0, "idtransactiontype")
                    jenistransselect = sqls.getDataSet("getidtrans", 0, "jenistransaksi")
                    formatstring = sqls.getDataSet("getidtrans", 0, "formatstring")
                    formatperiode = sqls.getDataSet("getidtrans", 0, "formatperiode")
                Else
                    idtransselect = 0
                    jenistransselect = ""
                    formatstring = ""
                    formatperiode = ""
                End If
                If idtransselect > 0 Then
                    teNoSOAP.Text = formatstring & Format(nowTime, formatperiode) & "/XXXX"
                Else
                    teNoSOAP.Text = "SOAP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
                End If

                teNoRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasino")
                teNoRegistrasi.Tag = idselect
                teTanggalPendaftaran.Text = sqls.getDataSet("getidrm", 0, "registrasidate")
                teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

                teNoRM.Text = sqls.getDataSet("registrasi", 0, "rekammedisno")
                teJenisKartu.Text = sqls.getDataSet("registrasi", 0, "jeniskartu")
                teNomorKartu.Text = sqls.getDataSet("registrasi", 0, "nomorkartu")
                teHamil.Text = sqls.getDataSet("getidrm", 0, "hamil")
                teGolonganDarah.Text = sqls.getDataSet("registrasi", 0, "golongandarah")
                teRhesus.Text = sqls.getDataSet("registrasi", 0, "rhesus")

                teNoRM.Tag = sqls.getDataSet("registrasi", 0, "idrekammedis")
                teNamaPanggilan.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teNama.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teJenisKelamin.Text = sqls.getDataSet("registrasi", 0, "jeniskelamin")
                teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
                teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
                teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

                sqls.DMLQuery("select idsoapnote from soapnote where idregistrasi=" & idselect, "getidass")
                If sqls.getDataSet("getidass") > 0 Then
                    idd = sqls.getDataSet("getidass", 0, "idsoapnote")
                End If

                If sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 0 Then
                    imgAnatomi = My.Resources.anatomi_w
                ElseIf sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 1 Then
                    imgAnatomi = My.Resources.anatomi_p
                End If
                peAnatomi.Image = imgAnatomi

                tlpField.Enabled = True
                btnSearch.Enabled = True
                btnSave.Enabled = True
                btnSavePrint.Enabled = True
            End If
        Else
            idselect = idd
            sqls = New SQLs(dbstring)
            sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi=" & idselect, "getidrm")
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idselect})
            sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

            iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
            idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

            sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%SOAPNOTE%' and iddepartment=" & iddeptselect & " and idunit=" & idunitselect, "getidtrans")
            If sqls.getDataSet("getidtrans") > 0 Then
                idtransselect = sqls.getDataSet("getidtrans", 0, "idtransactiontype")
                jenistransselect = sqls.getDataSet("getidtrans", 0, "jenistransaksi")
                formatstring = sqls.getDataSet("getidtrans", 0, "formatstring")
                formatperiode = sqls.getDataSet("getidtrans", 0, "formatperiode")
            Else
                idtransselect = 0
                jenistransselect = ""
                formatstring = ""
                formatperiode = ""
            End If
            If idtransselect > 0 Then
                teNoSOAP.Text = formatstring & Format(nowTime, formatperiode) & "/XXXX"
            Else
                teNoSOAP.Text = "SOAP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            End If

            teNoRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasino")
            teNoRegistrasi.Tag = idselect
            teTanggalPendaftaran.Text = sqls.getDataSet("getidrm", 0, "registrasidate")
            teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

            teNoRM.Text = sqls.getDataSet("registrasi", 0, "rekammedisno")
            teJenisKartu.Text = sqls.getDataSet("registrasi", 0, "jeniskartu")
            teNomorKartu.Text = sqls.getDataSet("registrasi", 0, "nomorkartu")
            teHamil.Text = sqls.getDataSet("getidrm", 0, "hamil")
            teGolonganDarah.Text = sqls.getDataSet("registrasi", 0, "golongandarah")
            teRhesus.Text = sqls.getDataSet("registrasi", 0, "rhesus")

            teNoRM.Tag = sqls.getDataSet("registrasi", 0, "idrekammedis")
            teNamaPanggilan.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
            teNama.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
            teJenisKelamin.Text = sqls.getDataSet("registrasi", 0, "jeniskelamin")
            teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
            teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
            teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

            sqls.DMLQuery("select idsoapnote from soapnote where idregistrasi=" & idselect, "getidass")
            If sqls.getDataSet("getidass") > 0 Then
                idd = sqls.getDataSet("getidass", 0, "idsoapnote")
            End If

            If sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 0 Then
                imgAnatomi = My.Resources.anatomi_w
            ElseIf sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 1 Then
                imgAnatomi = My.Resources.anatomi_p
            End If
            peAnatomi.Image = imgAnatomi
            tlpField.Enabled = True
            btnSearch.Enabled = True
            btnSave.Enabled = True
            btnSavePrint.Enabled = True
        End If
    End Sub

End Class