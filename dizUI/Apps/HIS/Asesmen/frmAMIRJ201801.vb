Imports DevExpress.XtraGrid.Views.Base
Public Class frmAMIRJ201801
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
        Dim sqls As New SQLs(dbstring)
    End Sub

    Private idselect As String = "-1"

    Private jenistransselectso As String = ""
    Private idtransselectso As String = "0"
    Private formatstringso As String = ""
    Private formatperiodeso As String = ""

    Private jenistransselectas As String = ""
    Private idtransselectas As String = "0"
    Private formatstringas As String = ""
    Private formatperiodeas As String = ""

    Private iddeptselect As String = "-1"
    Private idunitselect As String = "-1"
    Private isFromLoad As Boolean = True
    Private imgAnatomi As Image = Nothing

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub kosongkan()
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpTandaVital1)
        kosongkanIsian(tlppSOAP)
        meDiagnosaKerja.Text = ""
        meDiagnosaKerja.EditValue = Nothing

        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        _anatomi = anatomiType.ZZ

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = 0
        teNoRM.Text = 0
        teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = True
        btnCetakASESMEN.Enabled = True
        statData = statusData.Baru

        iddeptselect = 0
        idunitselect = 0
        idselect = "-1"

        isoneday = 0
        If isoneday = 0 Then
            btnODS.Text = "ODS / ODC"
            teNoRegistrasi.Text = ""
        ElseIf isoneday = 1 Then
            btnODS.Text = "REGULER"
            teNoRegistrasi.Text = ""
        End If

        iddas = "-1"
        idtransselectas = "0"
        jenistransselectas = ""
        formatstringas = ""
        formatperiodeas = ""

        iddso = "-1"
        idtransselectso = "0"
        jenistransselectso = ""
        formatstringso = ""
        formatperiodeso = ""

        teNoAsesmen.Text = "XXXX/IRJ/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teNoSOAP.Text = "XXXX/IRJ/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

        imgAnatomi = Nothing
        peAnatomi.Image = Nothing
        isPoint = False

        tmrCek.Stop()
        tlpAsesmen.Enabled = False
        tlpSOAP.Enabled = False

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = False
        btnCetakASESMEN.Enabled = False
        btnSimpanSOAP.Enabled = False
        btnCetakSOAP.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isFromLoad = True Then
            kosongkanIsian(tlpRegistrasi)
            kosongkanIsian(tlpPasien)
            kosongkanIsian(tlpAlamat)
            kosongkanIsian(tlpTandaVital1)
            kosongkanIsian(tlppSOAP)
            meDiagnosaKerja.Text = ""
            meDiagnosaKerja.EditValue = Nothing

            For Each btn As Button In tlpAnatomiTools.Controls
                btn.BackColor = Color.FromArgb(224, 224, 224)
            Next
            btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
            _anatomi = anatomiType.ZZ

            teNoRegistrasi.Text = ""
            teNoRegistrasi.Tag = 0
            teNoRM.Tag = 0
            teNoRM.Text = 0
            teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teGolonganDarah.Tag = ""
            teJenisKelamin.Tag = ""
            teWarganegara.Tag = ""

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = True
            btnCetakASESMEN.Enabled = True
            statData = statusData.Baru

            iddeptselect = 0
            idunitselect = 0
            idselect = "-1"

            isoneday = 0
            If isoneday = 0 Then
                btnODS.Text = "ODS / ODC"
                teNoRegistrasi.Text = ""
            ElseIf isoneday = 1 Then
                btnODS.Text = "REGULER"
                teNoRegistrasi.Text = ""
            End If

            iddas = "-1"
            idtransselectas = "0"
            jenistransselectas = ""
            formatstringas = ""
            formatperiodeas = ""

            iddso = "-1"
            idtransselectso = "0"
            jenistransselectso = ""
            formatstringso = ""
            formatperiodeso = ""

            teNoAsesmen.Text = "XXXX/IRJ/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            teNoSOAP.Text = "XXXX/IRJ/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            imgAnatomi = Nothing
            peAnatomi.Image = Nothing
            isPoint = False

            tmrCek.Stop()
            tlpAsesmen.Enabled = False
            tlpSOAP.Enabled = False

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = False
            btnCetakASESMEN.Enabled = False
            btnSimpanSOAP.Enabled = False
            btnCetakSOAP.Enabled = False
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDIRJDept') order by r.registrasidate desc", "search")
            Dim cari As New frmSearchTanggal(sqls.dataSet, "search", "idregistrasi", "Tgl Registrasi")
            tambahChild(cari)

            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                kosongkan()

                For Each btn As Button In tlpAnatomiTools.Controls
                    btn.BackColor = Color.FromArgb(224, 224, 224)
                Next
                _anatomi = anatomiType.ZZ

                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select isnull(dbo.fGetUsername(lockby),0) as username,isnull(dbo.fGetUsernama(lockby),'-') as nama,isnull(lockipaddress,'0.0.0.0') as lockipaddress from registrasi where datediff(second,lockdate,getdate())<=convert(int,(select isnull(value,4) from sys_appsetting where variable='TimeoutRegister')) and idregistrasi='" & CStr(cari.GetIDSelectData) & "'", "ceklock")
                If sqls.getDataSet("ceklock") > 0 Then
                    dizMsgbox("Sedang digunakan oleh" & vbCrLf &
                              sqls.getDataSet("ceklock", 0, "username") & " (" & sqls.getDataSet("ceklock", 0, "username") & ")" & vbCrLf &
                              "IP Address " & sqls.getDataSet("ceklock", 0, "lockipaddress"), dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If

                isoneday = 0
                If isoneday = 0 Then
                    btnODS.Text = "ODS / ODC"
                    teNoRegistrasi.Text = ""
                ElseIf isoneday = 1 Then
                    btnODS.Text = "REGULER"
                    teNoRegistrasi.Text = ""
                End If

                iddas = "-1"
                iddso = "-1"
                teNoAsesmen.Tag = "-1"
                teNoSOAP.Tag = "-1"
                isPoint = False

                idselect = CStr(cari.GetIDSelectData)
                tmrCek.Start()

                sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselect & "'", "getidrm")
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@idrm"})
                value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
                sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

                isoneday = sqls.getDataSet("getidrm", 0, "isoneday")
                If isoneday = 0 Then
                    btnODS.Text = "ODS / ODC"
                ElseIf isoneday = 1 Then
                    btnODS.Text = "REGULER"
                End If

                iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
                idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "AssessmentMedis", True)
                idtransselectas = pair.Key
                teNoAsesmen.Text = pair.Value

                sqls.DMLQuery("select jenistransaksi,formatstring,formatperiode from transactiontype where idtransactiontype='" & idtransselectas & "'", "getttas")
                jenistransselectas = sqls.getDataSet("getttas", 0, "jenistransaksi")
                formatstringas = sqls.getDataSet("getttas", 0, "formatstring")
                formatperiodeas = sqls.getDataSet("getttas", 0, "formatperiode")

                Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", True)
                idtransselectso = pair2.Key
                teNoSOAP.Text = pair2.Value

                sqls.DMLQuery("select jenistransaksi,formatstring,formatperiode from transactiontype where idtransactiontype='" & idtransselectso & "'", "getttso")
                jenistransselectso = sqls.getDataSet("getttso", 0, "jenistransaksi")
                formatstringso = sqls.getDataSet("getttso", 0, "formatstring")
                formatperiodeso = sqls.getDataSet("getttso", 0, "formatperiode")

                teNoRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasino")
                teNoRegistrasi.Tag = idselect
                noreg = sqls.getDataSet("getidrm", 0, "registrasino")
                If isoneday = 0 Then
                    teNoRegistrasi.Text = noreg
                ElseIf isoneday = 1 Then
                    teNoRegistrasi.Text = noreg & " (ODS)"
                End If

                idreg = idselect
                teTanggalRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasidate")
                teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
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
                teJenisKelamin.Tag = sqls.getDataSet("registrasi", 0, "idjeniskelamin")
                If sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 0 Then
                    imgAnatomi = My.Resources.anatomi_w
                ElseIf sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 1 Then
                    imgAnatomi = My.Resources.anatomi_p
                End If
                sqls.DMLQuery("select images from anatomi a left join sys_images i on a.idimages=i.idimages where a.idregistrasi='" & idselect & "' and a.isdeleted=0", "getimg")
                If sqls.getDataSet("getimg") > 0 Then
                    imgAnatomi = Image.FromStream(New IO.MemoryStream(DirectCast(sqls.getDataSet("getimg", 0, "images"), Byte())))
                    mouseClicked = True
                End If
                peAnatomi.Image = imgAnatomi

                teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
                teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
                teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

                'Assessment
                sqls.DMLQuery("select idassessment from assessment where idregistrasi='" & idselect & "' and transactiontype='" & idtransselectas & "' and isdeleted=0 order by idassessment desc", "getidass")
                If sqls.getDataSet("getidass") > 0 Then
                    iddas = sqls.getDataSet("getidass", 0, "idassessment")
                End If

                If iddas <> "-1" Then
                    sqls.DMLQuery("select assessmentno,fungsitubuh,strukturtubuh,aktifitas,partisipasi,faktorlingkungan,faktorpersonal from assessment where idassessment='" & iddas & "'", "getass")

                    teNoAsesmen.Tag = iddas
                    teNoAsesmen.Text = sqls.getDataSet("getass", 0, "assessmentno")
                    'meFungsi.Text = sqls.getDataSet("getass", 0, "fungsitubuh")
                    'meStruktur.Text = sqls.getDataSet("getass", 0, "strukturtubuh")
                    'meAktifitas.Text = sqls.getDataSet("getass", 0, "aktifitas")
                    'mePartisipasi.Text = sqls.getDataSet("getass", 0, "partisipasi")
                    'meLingkungan.Text = sqls.getDataSet("getass", 0, "faktorlingkungan")
                    'mePersonal.Text = sqls.getDataSet("getass", 0, "faktorpersonal")

                    Dim sqls1 As New SQLs(dbstring)
                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=1 order by i.kode asc", "1ak")
                    Dim ak As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("1ak") - 1
                        ak.Add(sqls1.getDataSet("1ak", i, "diagnosa"))
                    Next
                    meAktifitas.Text = String.Join(vbCrLf, ak)

                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=2 order by i.kode asc", "2li")
                    Dim li As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("2li") - 1
                        li.Add(sqls1.getDataSet("2li", i, "diagnosa"))
                    Next
                    meLingkungan.Text = String.Join(vbCrLf, li)

                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=3 order by i.kode asc", "3so")
                    Dim so As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("3so") - 1
                        so.Add(sqls1.getDataSet("3so", i, "diagnosa"))
                    Next
                    mePersonal.Text = String.Join(vbCrLf, so)

                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=4 order by i.kode asc", "4tu")
                    Dim tu As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("4tu") - 1
                        tu.Add(sqls1.getDataSet("4tu", i, "diagnosa"))
                    Next
                    meFungsi.Text = String.Join(vbCrLf, tu)

                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=5 order by i.kode asc", "5pa")
                    Dim pa As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("5pa") - 1
                        pa.Add(sqls1.getDataSet("5pa", i, "diagnosa"))
                    Next
                    mePartisipasi.Text = String.Join(vbCrLf, pa)

                    sqls1.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=6 order by i.kode asc", "6st")
                    Dim st As New List(Of String)
                    For i As Integer = 0 To sqls1.getDataSet("6st") - 1
                        st.Add(sqls1.getDataSet("6st", i, "diagnosa"))
                    Next
                    meStruktur.Text = String.Join(vbCrLf, st)
                End If

                sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,i.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
                If sqls.getDataSet("getdiagnosa") > 0 Then
                    Me.meDiagnosaKerja.Text = ""
                    For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                        meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                        If i < sqls.getDataSet("getdiagnosa") - 1 Then
                            meDiagnosaKerja.Text &= vbCrLf
                        End If
                    Next
                Else
                    meDiagnosaKerja.Text = ""
                End If

                'SOAP
                sqls.DMLQuery("select idsoapnote from soapnote where idregistrasi='" & idreg & "' and transactiontype='" & idtransselectso & "' and isdeleted=0", "getidso")
                If sqls.getDataSet("getidso") > 0 Then
                    iddso = sqls.getDataSet("getidso", 0, "idsoapnote")
                End If

                If iddso <> "-1" Then
                    sqls.DMLQuery("select soapnoteno,convert(varchar,soapnotedate,105)+' '+convert(varchar,soapnotedate,108) as soapnotedate,subyektif,obyektif,asesmen,planning from soapnote where idregistrasi='" & idreg & "' and transactiontype='" & idtransselectso & "' and isdeleted=0", "getso")
                    teNoSOAP.Tag = iddso

                    Dim oTrim() As Char = {vbCr, vbLf}
                    Dim ases As String = sqls.getDataSet("getso", 0, "planning")
                    ases = ases.Replace("Rencana Diagnosa:", "`")
                    ases = ases.Replace("Rencana Terapi/Program/Tindakan:", "`")

                    teNoSOAP.Text = sqls.getDataSet("getso", 0, "soapnoteno")
                    meSubjektif.Text = sqls.getDataSet("getso", 0, "subyektif")
                    meObjektif.Text = sqls.getDataSet("getso", 0, "obyektif")
                    If meDiagnosaKerja.Text = "" Then
                        meDiagnosaKerja.Text = sqls.getDataSet("getso", 0, "asesmen")
                    End If

                    Dim asesk As String = ""
                    If ases <> "" Then
                        asesk = ases.Split("`")(1)
                        If asesk.EndsWith(vbCrLf) Then
                            asesk = asesk.TrimEnd(oTrim)
                        End If
                        If asesk.StartsWith(vbCrLf) Then
                            asesk = asesk.TrimStart(oTrim)
                        End If
                    End If
                    meRencanaDiagnosa.Text = asesk

                    Dim asesb As String = ""
                    If ases <> "" Then
                        asesb = ases.Split("`")(2)
                        If asesb.EndsWith(vbCrLf) Then
                            asesb = asesb.TrimEnd(oTrim)
                        End If
                        If asesb.StartsWith(vbCrLf) Then
                            asesb = asesb.TrimStart(oTrim)
                        End If
                    End If
                    meRencanaTerapi.Text = asesb
                End If

                tlpAsesmen.Enabled = True
                tlpSOAP.Enabled = True

                btnSearch.Enabled = True
                btnSimpanASESMEN.Enabled = True
                btnCetakASESMEN.Enabled = True
                btnSimpanSOAP.Enabled = True
                btnCetakSOAP.Enabled = True
            End If
        End If
        isFromLoad = False
    End Sub

    Private isMouseDown As Boolean = False
    Private mouseClicked As Boolean = False
    Private mousePos As Point
    Private sizeShape As Single = 50
    Private Sub peAnatomi_Paint(sender As Object, e As PaintEventArgs) Handles peAnatomi.Paint
        If mouseClicked Then
            If isMouseDown Then
                If isClearImg = False Then
                    If mousePos.X > 0 And mousePos.Y > 0 Then
                        Using bmp As New Bitmap(peAnatomi.Image) 'lets get the original image
                            Using g As Graphics = Graphics.FromImage(bmp)
                                DrawACircle(g, mousePos, 40)
                                'DrawACircle(e.Graphics, mousePos, 50)
                                peAnatomi.Image = CType(bmp.Clone, Image)
                                isMouseDown = False
                            End Using
                        End Using
                    End If
                Else
                    peAnatomi.Image = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub peAnatomi_MouseDown(sender As Object, e As MouseEventArgs) Handles peAnatomi.MouseDown
        If _anatomi = anatomiType.ZZ Then
            dizMsgbox("Pilih jenis Mark disisi samping kiri", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        mouseClicked = True
        mousePos = New Point(e.X - 42, e.Y - 20)
        'mousePos = New Point(peAnatomi.PointToClient(Control.MousePosition))
        isMouseDown = True
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
        Dim df As New StringFormat
        df.Alignment = StringAlignment.Center
        df.LineAlignment = StringAlignment.Center

        If _anatomi = anatomiType.A Then
            g.DrawEllipse(pn, rect)
            g.DrawString("A", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.B Then
            g.DrawEllipse(pn, rect)
        ElseIf _anatomi = anatomiType.C Then
            g.DrawEllipse(pn, rect)
            g.DrawString("C", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.CF Then
            g.DrawEllipse(pn, rect)
            g.DrawString("CF", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.D Then
            g.DrawEllipse(pn, rect)
            g.DrawString("D", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.H Then
            g.DrawEllipse(pn, rect)
            g.DrawString("H", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.N Then
            g.DrawEllipse(pn, rect)
            g.DrawString("N", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.OF1 Then
            g.DrawEllipse(pn, rect)
            g.DrawString("OF", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.U Then
            g.DrawEllipse(pn, rect)
            g.DrawString("U", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.V Then
            g.DrawEllipse(pn, rect)
            g.DrawString("V", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.SD Then
            g.DrawEllipse(pn, rect)
            g.DrawString("SD", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.ST Then
            g.DrawEllipse(pn, rect)
            g.DrawString("ST", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.OE Then
            g.DrawEllipse(pn, rect)
            g.DrawString("OE", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.CR Then
            g.DrawEllipse(pn, rect)
            g.DrawString("CR", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.W Then
            g.DrawEllipse(pn, rect)
            g.DrawString("W", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.Int Then
            g.DrawString(nudNumbering.Value, New Font("Calibri", 16.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        End If
    End Sub

    Private isClearImg As Boolean = False
    Private isPoint As Boolean = False
    Private Sub btnAnatomiCLear_Click(sender As Object, e As EventArgs) Handles btnAnatomiClear.Click
        isClearImg = True
        peAnatomi.Image = Nothing
        peAnatomi.Invalidate()
        mousePos.X = 0
        mousePos.Y = 0
        Threading.Thread.Sleep(100)

        If teJenisKelamin.Tag = 0 Then
            imgAnatomi = My.Resources.anatomi_w
        ElseIf teJenisKelamin.Tag = 1 Then
            imgAnatomi = My.Resources.anatomi_p
        End If

        peAnatomi.Image = imgAnatomi
        isClearImg = False
        isPoint = False

        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        _anatomi = anatomiType.ZZ
    End Sub

    Private ipadd As String
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        tlpAsesmen.Dock = DockStyle.Top

        checkFieldMaxLength(dbstring, tlpTandaVital1, "assessment")
        checkFieldMaxLength(dbstring, tlppSOAP, "soapnote")
        imgAnatomi = Nothing
        tmrCek.Stop()
        ipadd = getIPAddress(ipaddparam.IP)

        loadLOV()
        btnSearch_Click(Me, Nothing)

        Dim pntx As Integer = (Me.Size.Width / 2) - (pAnatomi.Size.Width / 2)
        Dim pnty As Integer = (Me.Size.Height / 2) - (pAnatomi.Size.Height / 2)
        pAnatomi.Location = New Point(pntx, pnty)
        pAnatomi.SendToBack()

        btnAnatomiClear.Size = New Size(100, 30)
        nudNumbering.Size = New Size(48, 30)
        btnNumbering.Size = New Size(50, 30)

        gcAntrian.Size = New Size(196, 527)
        tlpAntrian.ColumnStyles.Item(0).Width = 162
        tlpAntrian.ColumnStyles.Item(1).Width = 30

        tlpAntrian.RowStyles.Item(0).Height = 30
        tlpAntrian.RowStyles.Item(1).Height = 90
        tlpAntrian.RowStyles.Item(2).Height = 6
        tlpAntrian.RowStyles.Item(3).Height = 90
        tlpAntrian.RowStyles.Item(4).Height = 6
        tlpAntrian.RowStyles.Item(5).Height = 90
        tlpAntrian.RowStyles.Item(6).Height = 6
        tlpAntrian.RowStyles.Item(7).Height = 90
        tlpAntrian.RowStyles.Item(8).Height = 6
        tlpAntrian.RowStyles.Item(9).Height = 90

        tlpAntrian.Size = New Size(192, 504)

        gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - ((gcAntrian.Size.Height - tlpAntrian.Size.Height) + lblAntrian.Size.Height - 2))
        btnAntrianMin.Tag = "Max"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iduser from paramedis where iduser='" & userid & "'", "cekuser")
        If sqls.getDataSet("cekuser") > 0 Then
            gcAntrian.Visible = True
        Else
            gcAntrian.Visible = False
        End If
    End Sub

    Private Function generateNO(jenisregistrasi As String, ByVal prefix As String, formatperiode As String, Optional wildchar As String = "") As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = jenisregistrasi & Format(nowTime, "yyyyMMdd")
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & Format(nowTime, formatperiode) & "/"
            currid = 1
            posnumber = "Belakang"
            lenId = 4
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        Dim strwildchar As String = wildchar.Substring(0)
        If wildchar = "" Then
            For i As Integer = 0 To lenId - 1
                If i = 0 Then
                    lenStr = "0"
                Else
                    lenStr &= "#"
                End If
            Next
            currStrId = Format(currid, lenStr)
        Else
            For i As Integer = 0 To lenId - 1
                lenStr &= strwildchar
            Next
            currStrId = lenStr
        End If

        If posnumber = "Belakang" Then
            retval = formatStr & currStrId
        ElseIf posnumber = "Depan" Then
            retval = currStrId & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
    End Function

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
        retval = modCore.checkEntry(tlpTandaVital1)
        If idselect = "-1" Then retval = False
        Return retval
    End Function

    Private isoneday As String = 0
    Private noreg As String = ""
    Private idreg As String = "-1"
    Private iddas As String = "-1"
    Private iddso As String = "-1"
    Private Sub btnSimpanASESMEN_Click(sender As Object, e As EventArgs) Handles btnSimpanASESMEN.Click
        Dim cek As Boolean = True
        'cek = mouseClicked
        'If cek = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Info, Me)
        '    Exit Sub
        'End If
        cek = prosesSimpan()
        If cek = False Then
            dizMsgbox("Asesmen belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanSOAP()
        If cek = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        If cek = True Then
            dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnCetakASESMEN_Click(sender As Object, e As EventArgs) Handles btnCetakASESMEN.Click
        Dim cek As Boolean = True
        'cek = mouseClicked
        'If cek = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Info, Me)
        '    Exit Sub
        'End If
        cek = prosesSimpan()
        If cek = False Then
            dizMsgbox("Asesmen belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanSOAP()
        If cek = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        If cek = True Then
            dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
            cetakBerkasAMRJ(iddas, idreg)
        End If
    End Sub


    Private Function prosesSimpan() As Boolean
        Dim cek As Boolean = True
        'If checkEntry() = False Then
        '    dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
        '    cek = False
        'End If
        If cek = True Then
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If iddas <> "-1" Then
                field.AddRange(New String() {"idassessment", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {iddas, 1, userid, nowTime})
                dtsqls.datasetSave("assessment", iddas, field, value, False)
            End If

            If iddas = "-1" Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "AssessmentMedis", False)
                idtransselectas = pair.Key
                teNoAsesmen.Text = pair.Value
                iddas = GenerateGUID()
            End If

            Dim dtsqls1 As New dtsetSQLS(dbstring)
            Dim field1 As New List(Of String)
            Dim value1 As New List(Of Object)

            'Dim strguid As String = GenerateUniqueID(GenerateHash(Format(nowTime, "ddMMyyyyHHmmssff") & idhostname), 1000)

            field1.AddRange(New String() {"idassessment", "idregistrasi", "transactiontype", "assessmentno", "fungsitubuh", "strukturtubuh", "aktifitas", "partisipasi", "faktorlingkungan", "faktorpersonal", "isdeleted", "createdby", "idcompany", "nomorform"})

            value1.AddRange(New Object() {iddas, idselect, idtransselectas, teNoAsesmen.Text, meFungsi.Text, meStruktur.Text, meAktifitas.Text, mePartisipasi.Text, meLingkungan.Text, mePersonal.Text, 0, userid, idcomp, "AMIRJ201801"})

            cek = dtsqls1.datasetSave("assessment", iddas, field1, value1, False)
            Dim sqls As New SQLs(dbstring)
            'sqls.DMLQuery("select idassessment from assessment where guid='" & strguid & "'", "getidas")
            'iddas = cstr(sqls.getDataSet("getidas", 0, "idassessment"))

            sqls.DMLQuery("update registrasi set isasesmenmedis=1 where idregistrasi='" & idselect & "'", False)
        End If

        If cek = True Then
            'dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Sub cetakBerkasAMRJ(iddata As String, idreg As String)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIRJ201801", "asmrj", field, value)

        Dim mysSOAP As New SQLs(dbstring)
        mysSOAP.CallSP("spSN201801", "soap", field2, value2)

        Dim mysAMU As New SQLs(dbstring)
        mysAMU.CallSP("spAMunit", "unit", field, value)

        Dim mysSNU As New SQLs(dbstring)
        mysSNU.CallSP("spSNunit", "unit", field2, value2)

        Dim mysAn As New SQLs(dbstring)
        mysAn.CallSP("spAnatomi", "anatomi", field2, value2)

        Dim rptAn As New xrAnatomiSQ
        rptAn.RequestParameters = False
        rptAn.DataAdapter = mysAn.getDataAdapter
        rptAn.DataSource = mysAn.dataSet
        rptAn.DataMember = "anatomi"

        Dim rptSOAP As New xrSOAPIncRJ201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIRJ201901
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmrj"
        rpt.DisplayName = "AMIRJ201901"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pID").Visible = False
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pNo").Visible = False
        rpt.Parameters("pUnit").Value = mysAMU.getDataSet("unit", 0, "unit")
        rpt.Parameters("pUnit").Visible = False
        rpt.Parameters("pNotes").Value = mysSNU.getDataSet("unit", 0, "notes")
        rpt.Parameters("pNotes").Visible = False
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.Parameters("pFooter").Visible = False
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        'pt.Print()
        Dim sharename As String = getPrinter("ASMIRJ")
        If sharename <> "" Then
            Try
                pt.Print(sharename)
            Catch ex As Exception
                dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan, me)
            End Try
        Else
            dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
        End If

        'Dim sd As New frmSelectDevice
        'tambahChild(sd)
        'If sd.ShowDialog() = DialogResult.OK Then
        '    pt.Print(sd.getdevicename)
        'End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub


    Private Sub btnSimpanSOAP_Click(sender As Object, e As EventArgs) Handles btnSimpanSOAP.Click
        prosesSimpanSOAP()
    End Sub

    Private Sub btnCetakSOAP_Click(sender As Object, e As EventArgs) Handles btnCetakSOAP.Click
        If prosesSimpanSOAP() = True Then
            cetakBerkasAMRJ(iddas, idreg)
        End If
    End Sub

    Private Function prosesSimpanSOAP() As Boolean
        Dim cek As Boolean = True
        If modCore.checkEntry(tlppSOAP) = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        Dim strdk As String = meRencanaDiagnosa.Text.Replace(" ", "")
        strdk = strdk.ToLower
        If strdk.Contains("rencanadiagnosa") Then
            dizMsgbox("Rencana Diagnosa tidak perlu mencantumkan 'Rencana Diagnosa'", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        Dim strdb As String = meRencanaTerapi.Text.Replace(" ", "")
        strdb = strdb.ToLower
        If strdb.Contains("rencanaterapi/program/tindakan") Then
            dizMsgbox("Rencana Terapi tidak perlu mencantumkan 'Rencana Terapi/Program/Tindakan'", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        'If mouseClicked = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Peringatan, Me)
        '    cek = False
        'End If

        If cek = True Then
            If iddso = "-1" Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", False)
                idtransselectso = pair.Key
                teNoSOAP.Text = pair.Value
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update soapnote set isdeleted=1 where idregistrasi='" & idreg & "'", False)

            sqls.DMLQuery("select iddokterruangan,idspesialisruangan from registrasi where idregistrasi='" & idreg & "'", "getidsp")
            Dim idparru As String = sqls.getDataSet("getidsp", 0, "iddokterruangan")
            Dim idspru As String = sqls.getDataSet("getidsp", 0, "idspesialisruangan")

            If meDiagnosaKerja.Text = "" Or meDiagnosaKerja.Text = " " Then
                sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,i.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
                If sqls.getDataSet("getdiagnosa") > 0 Then
                    Me.meDiagnosaKerja.Text = ""
                    For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                        If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                            meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                        Else
                            meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                        End If
                        If i < sqls.getDataSet("getdiagnosa") - 1 Then
                            meDiagnosaKerja.Text &= vbCrLf
                        End If
                    Next
                Else
                    meDiagnosaKerja.Text = ""
                End If
            End If

            iddso = GenerateGUID()
            'Dim strguid As String = GenerateUniqueID(GenerateHash(Format(nowTime, "ddMMyyyyHHmmssff") & idhostname), 1000)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "idregistrasi", "transactiontype", "soapnotetype", "soapnoteno", "soapnotedate", "subyektif", "obyektif", "asesmen", "planning", "createdby", "createddate", "idparamediscreator", "idspesialiscreator", "paramediscreatortype"})
            value2.AddRange(New Object() {iddso, idselect, idtransselectso, 1, teNoSOAP.Text, nowTime, meSubjektif.Text, meObjektif.Text, meDiagnosaKerja.Text, "Rencana Diagnosa:" & vbCrLf & meRencanaDiagnosa.Text & vbCrLf & "Rencana Terapi/Program/Tindakan:" & vbCrLf & meRencanaTerapi.Text, userid, nowTime, idparru, idspru, 8})
            cek = dtsqls2.datasetSave("soapnote", iddso, field2, value2, False)
            'sqls.DMLQuery("select idsoapnote from soapnote where hashcode='" & strguid & "'", "getidso")
            '    iddso = cstr(sqls.getDataSet("getidso", 0, "idsoapnote"))

            cek = prosesSimpanIMG(idreg)
            End If

            If cek = True Then
            'dizMsgbox("SOAP Note telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Function prosesSimpanIMG(idregistrasi As String) As Boolean
        Dim retval As Boolean = False
        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        Dim imgByteArray As Byte() = Nothing
        Dim img As Image = peAnatomi.Image
        Dim mysqls As New SQLs(dbstring)
        Dim tglskrg As Date = nowTime

        img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
        imgByteArray = imgMemoryStream.GetBuffer()
        Dim idimages As String = GenerateGUID()
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idimages", "datetime", "filename", "sizewidth", "sizeheight", "images"})
        value.AddRange(New Object() {idimages, nowTime, "Anatomi" & idregistrasi & Format(tglskrg, "MMddyyyyHHmmss") & ".png", img.Size.Width, img.Size.Height, imgByteArray})
        dtsql.datasetSave("sys_images", idimages, field, value, False)

        dtsql = New dtsetSQLS(dbstring)
        field.Clear()
        value.Clear()

        Dim idanatomi As String = GenerateGUID()
        field.AddRange(New String() {"idanatomi", "idregistrasi", "idimages", "createdby"})
        value.AddRange(New Object() {idanatomi, idregistrasi, idimages, userid})
        retval = dtsql.datasetSave("anatomi", idanatomi, field, value, False)
        If retval = True Then
            mysqls.DMLQuery("update anatomi set isdeleted=1 where idimages<>'" & idimages & "' and idregistrasi='" & idregistrasi & "'", False)
        End If
        Return retval
    End Function

    Private Sub btnAnatomi_Click(sender As Object, e As EventArgs) Handles btnAnatomi.Click
        If imgAnatomi Is Nothing Then
            dizMsgbox("Belum memilih registrasi", dizMsgboxStyle.Info, "Belum memilih", Me)
            Exit Sub
        End If
        pAnatomi.Visible = True
        pAnatomi.BringToFront()
        tlpForm.Enabled = False
    End Sub

    Private Sub btnAnatomiExit_Click(sender As Object, e As EventArgs) Handles btnAnatomiExit.Click
        pAnatomi.SendToBack()
        pAnatomi.Visible = False
        tlpForm.Enabled = True
    End Sub

    Private _anatomi As anatomiType

    Private Enum anatomiType
        ZZ = 0
        A = 1
        B = 2
        C = 3
        CF = 4
        D = 5
        H = 6
        N = 7
        OF1 = 8
        U = 9
        V = 10
        ST = 11
        SD = 12
        OE = 13
        CR = 14
        W = 15
        Int = 99
    End Enum

    Private Sub btnAnatomiTools_Click(sender As Object, e As EventArgs) Handles btnAnatomiA.Click, btnAnatomiC.Click, btnAnatomiCF.Click, btnAnatomiD.Click, btnAnatomiH.Click, btnAnatomiN.Click, btnAnatomiOF.Click, btnAnatomiU.Click, btnAnatomiV.Click, btnAnatomi.Click, btnAnatomiB.Click, btnAnatomiST.Click, btnAnatomiSD.Click, btnAnatomiOE.Click, btnAnatomiCR.Click, btnAnatomiW.Click, btnNumbering.Click
        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        CType(sender, Button).BackColor = Color.Gray
        If CType(sender, Button) Is btnAnatomiB Then
            _anatomi = anatomiType.B
        ElseIf CType(sender, Button) Is btnAnatomiA Then
            _anatomi = anatomiType.A
        ElseIf CType(sender, Button) Is btnAnatomiC Then
            _anatomi = anatomiType.C
        ElseIf CType(sender, Button) Is btnAnatomiCF Then
            _anatomi = anatomiType.CF
        ElseIf CType(sender, Button) Is btnAnatomiD Then
            _anatomi = anatomiType.D
        ElseIf CType(sender, Button) Is btnAnatomiH Then
            _anatomi = anatomiType.H
        ElseIf CType(sender, Button) Is btnAnatomiN Then
            _anatomi = anatomiType.N
        ElseIf CType(sender, Button) Is btnAnatomiOF Then
            _anatomi = anatomiType.OF1
        ElseIf CType(sender, Button) Is btnAnatomiU Then
            _anatomi = anatomiType.U
        ElseIf CType(sender, Button) Is btnAnatomiV Then
            _anatomi = anatomiType.V
        ElseIf CType(sender, Button) Is btnAnatomiST Then
            _anatomi = anatomiType.ST
        ElseIf CType(sender, Button) Is btnAnatomiSD Then
            _anatomi = anatomiType.SD
        ElseIf CType(sender, Button) Is btnAnatomiOE Then
            _anatomi = anatomiType.OE
        ElseIf CType(sender, Button) Is btnAnatomiCR Then
            _anatomi = anatomiType.CR
        ElseIf CType(sender, Button) Is btnAnatomiW Then
            _anatomi = anatomiType.W
        ElseIf CType(sender, Button) Is btnNumbering Then
            _anatomi = anatomiType.Int
        End If
    End Sub

    Private Sub frmAMRJ201801_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim pntx As Integer = (Me.Size.Width / 2) - (pAnatomi.Size.Width / 2)
        Dim pnty As Integer = (Me.Size.Height / 2) - (pAnatomi.Size.Height / 2)
        pAnatomi.Location = New Point(pntx, pnty)
    End Sub

    Private Sub tmrCek_Tick(sender As Object, e As EventArgs) Handles tmrCek.Tick
        If idselect = "-1" Then
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtst As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idregistrasi", "lockby", "lockdate", "lockipaddress"})
        value.AddRange(New Object() {idselect, userid, nowTime, ipadd})
        dtst.datasetSave("registrasi", idselect, field, value, False)
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum
    Private Sub btnCetakUlang_Click(sender As Object, e As EventArgs) Handles btnCetakUlang.Click
        Dim idasmu As String = "-1"
        Dim idregu As String = "-1"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDIRJDept') order by r.registrasidate desc", "search")
        Dim cari As New frmSearchTanggal(sqls.dataSet, "search", "idregistrasi", "Tgl Registrasi") 'frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = CStr(cari.GetIDSelectData)

            sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselectu & "'", "getidrm")

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
            sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

            Dim iddeptu As String = sqls.getDataSet("getidrm", 0, "iddepartment")
            Dim idunitu As String = sqls.getDataSet("getidrm", 0, "idunit")

            sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%AssessmentM%' and iddepartment='" & iddeptu & "' and idunit='" & idunitu & "'", "getidtransas")
            Dim idtranstypeu As String = "-1"
            If sqls.getDataSet("getidtransas") > 0 Then
                idtranstypeu = sqls.getDataSet("getidtransas", 0, "idtransactiontype")
            End If

            sqls.DMLQuery("select idassessment from assessment where idregistrasi='" & idselectu & "' and transactiontype='" & idtranstypeu & "' and isdeleted=0 order by idassessment desc", "getidass")
            If sqls.getDataSet("getidass") > 0 Then
                idregu = idselectu
                idasmu = sqls.getDataSet("getidass", 0, "idassessment")
            End If
            If idasmu = "-1" Then
                dizMsgbox("Belum dilakukan Assessment Medis", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
            Dim selectPrint As New frmPrintSelect()
            tambahChild(selectPrint)
            selectPrint.ShowDialog()

            If selectPrint.getStringPilih = "PREVIEW" Then
                previewBerkasAMRJ(idasmu, idregu, cu.preview)
            ElseIf selectPrint.getStringPilih = "CETAK" Then
                previewBerkasAMRJ(idasmu, idregu, cu.cetak)
            End If
        End If
    End Sub

    Private Sub previewBerkasAMRJ(iddata As String, idreg As String, cetaktype As cu)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIRJ201801", "asmrj", field, value)

        Dim mysSOAP As New SQLs(dbstring)
        mysSOAP.CallSP("spSN201801", "soap", field2, value2)

        Dim mysAMU As New SQLs(dbstring)
        mysAMU.CallSP("spAMunit", "unit", field, value)

        Dim mysSNU As New SQLs(dbstring)
        mysSNU.CallSP("spSNunit", "unit", field2, value2)

        Dim mysAn As New SQLs(dbstring)
        mysAn.CallSP("spAnatomi", "anatomi", field2, value2)

        Dim rptAn As New xrAnatomiSQ
        rptAn.RequestParameters = False
        rptAn.DataAdapter = mysAn.getDataAdapter
        rptAn.DataSource = mysAn.dataSet
        rptAn.DataMember = "anatomi"

        Dim rptSOAP As New xrSOAPIncRJ201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIRJ201901
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmrj"
        rpt.DisplayName = "AMIRJ201901"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pUnit").Value = mysAMU.getDataSet("unit", 0, "unit")
        rpt.Parameters("pNotes").Value = mysSNU.getDataSet("unit", 0, "notes")
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        If cetaktype = cu.cetak Then
            Dim sharename As String = getPrinter("ASMIRJ")
            If sharename <> "" Then
                Try
                    pt.Print(sharename)
                Catch ex As Exception
                    dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan, me)
                End Try
            Else
                dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
            End If
            'pt.Print()
        Else
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpTandaVital1)
        kosongkanIsian(tlppSOAP)
        meDiagnosaKerja.Text = ""
        meDiagnosaKerja.EditValue = Nothing

        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        _anatomi = anatomiType.ZZ

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = 0
        teNoRM.Text = 0
        teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = True
        btnCetakASESMEN.Enabled = True
        statData = statusData.Baru

        iddeptselect = 0
        idunitselect = 0
        idselect = "-1"
        noreg = ""

        isoneday = 0
        If isoneday = 0 Then
            btnODS.Text = "ODS / ODC"
        ElseIf isoneday = 1 Then
            btnODS.Text = "REGULER"
        End If

        iddas = "-1"
        idtransselectas = "0"
        jenistransselectas = ""
        formatstringas = ""
        formatperiodeas = ""

        iddso = "-1"
        idtransselectso = "0"
        jenistransselectso = ""
        formatstringso = ""
        formatperiodeso = ""

        teNoAsesmen.Text = "XXXX/IRJ/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teNoSOAP.Text = "XXXX/IRJ/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

        imgAnatomi = Nothing
        peAnatomi.Image = Nothing
        isPoint = False

        tmrCek.Stop()
        tlpAsesmen.Enabled = False
        tlpSOAP.Enabled = False

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = False
        btnCetakASESMEN.Enabled = False
        btnSimpanSOAP.Enabled = False
        btnCetakSOAP.Enabled = False
    End Sub

    Private Sub btnHistoriPasien_Click(sender As Object, e As EventArgs) Handles btnHistoriPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frmMon As New frmMonHistoriPasien(teNoRM.Tag)
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


    'Private Sub btnBaruRehab_Click(sender As Object, e As EventArgs) Handles btnBaruRehab.Click
    '    Dim sqls As New SQLs(dbstring)
    '    sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,i.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "cekicd")
    '    If sqls.getDataSet("cekicd") = 0 Then
    '        dizMsgbox("Diagnosa Kerja belum diisi", dizMsgboxStyle.Kesalahan, Me)
    '        Exit Sub
    '    End If
    '    'Dim cek As Boolean = True
    '    'cek = mouseClicked
    '    'If cek = False Then
    '    '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Info, Me)
    '    '    Exit Sub
    '    'End If
    '    'cek = True

    '    Dim lst As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("cekicd") - 1
    '        Dim dr As DataRow = sqls.dataTable("cekicd").Rows(i)
    '        lst.Add("'" & dr("idicd") & "'")
    '    Next
    '    Dim asrhb As New frmAsesmenRehab(iddas, idreg, lst)
    '    coll_child.Add(asrhb)
    '    asrhb.ShowDialog(Me)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=1 order by i.kode asc", "1ak")
    '    Dim ak As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("1ak") - 1
    '        ak.Add(sqls.getDataSet("1ak", i, "diagnosa"))
    '    Next
    '    meAktifitas.Text = String.Join(vbCrLf, ak)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=2 order by i.kode asc", "2li")
    '    Dim li As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("2li") - 1
    '        li.Add(sqls.getDataSet("2li", i, "diagnosa"))
    '    Next
    '    meLingkungan.Text = String.Join(vbCrLf, li)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=3 order by i.kode asc", "3so")
    '    Dim so As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("3so") - 1
    '        so.Add(sqls.getDataSet("3so", i, "diagnosa"))
    '    Next
    '    mePersonal.Text = String.Join(vbCrLf, so)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=4 order by i.kode asc", "4tu")
    '    Dim tu As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("4tu") - 1
    '        tu.Add(sqls.getDataSet("4tu", i, "diagnosa"))
    '    Next
    '    meFungsi.Text = String.Join(vbCrLf, tu)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=5 order by i.kode asc", "5pa")
    '    Dim pa As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("5pa") - 1
    '        pa.Add(sqls.getDataSet("5pa", i, "diagnosa"))
    '    Next
    '    mePartisipasi.Text = String.Join(vbCrLf, pa)

    '    sqls.DMLQuery("select d.idicd,i.kode + ' - ' + i.diagnosa as diagnosa,rh.generalcode as rhtype from assessmentrehab d left join icd i on d.idicd=i.idicd left join sys_generalcode rh on d.rehabmediktype=rh.idgeneral and rh.gctype='REHABMEDIKTYPE' where d.idregistrasi='" & idreg & "' and d.isdeleted=0 and d.rehabmediktype=6 order by i.kode asc", "6st")
    '    Dim st As New List(Of String)
    '    For i As Integer = 0 To sqls.getDataSet("6st") - 1
    '        st.Add(sqls.getDataSet("6st", i, "diagnosa"))
    '    Next
    '    meStruktur.Text = String.Join(vbCrLf, st)

    '    'cek = prosesSimpan()
    '    'If cek = False Then
    '    '    dizMsgbox("Asesmen belum benar", dizMsgboxStyle.Info, Me)
    '    '    Exit Sub
    '    'End If
    'End Sub

    Private Sub btnRegStatus_Click(sender As Object, e As EventArgs) Handles btnRegStatus.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select variable,value from sys_appsetting where variable in('IDIRJDept')", "getid")
        Dim rs As New frmRegistrasiUpdate(sqls.getDataSet("getid", 0, "value").ToString)
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnBaruDiagnosaKerja_Click(sender As Object, e As EventArgs) Handles btnBaruDiagnosaKerja.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If meDiagnosaKerja.Text.Length > 0 Then
            If dizMsgbox("Isian Diagnosa Kerja akan dihapus" & vbCrLf & "Tetap melanjutkan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim diagkerja As New frmDiagnosaKerja(iddso, idreg, "IRJ")
        tambahChild(diagkerja)
        diagkerja.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.StartPosition = FormStartPosition.CenterScreen
        diagkerja.tlpForm.RowCount = 4
        diagkerja.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        diagkerja.ShowDialog(Me)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
        If sqls.getDataSet("getdiagnosa") > 0 Then
            Me.meDiagnosaKerja.Text = ""
            For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                    meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                Else
                    meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                End If
                If i < sqls.getDataSet("getdiagnosa") - 1 Then
                    meDiagnosaKerja.Text &= vbCrLf
                End If
            Next
        Else
            meDiagnosaKerja.Text = ""
        End If
        diagkerja.Dispose()

        If iddso <> "-1" Then
            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "asesmen", "updatedby", "updateddate"})
            value2.AddRange(New Object() {teNoSOAP.Tag, meDiagnosaKerja.Text, userid, nowTime})
            dtsqls2.datasetSave("soapnote", teNoSOAP.Tag, field2, value2, False)
        End If
    End Sub

    Private Sub btnMonReg_Click(sender As Object, e As EventArgs) Handles btnMonReg.Click
        formTitle = ""
        Dim rs As New frmMonRegisterIRJday()
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnODS_Click(sender As Object, e As EventArgs) Handles btnODS.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isoneday = 0 Then
            isoneday = 1
            btnODS.Text = "REGULER"
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update registrasi set isoneday=1,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "'", False)
        ElseIf isoneday = 1 Then
            isoneday = 0
            btnODS.Text = "ODS / ODC"
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update registrasi set isoneday=0,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "'", False)
        End If
    End Sub

    Private Sub btnCetakGelang_Click(sender As Object, e As EventArgs) Handles btnCetakGelang.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='idirnadept')) or (r.registrasistatus=0 and rm.rekammedisno<>0 and r.isoneday=1 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDIRJDept')) order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = CStr(cari.GetIDSelectData)
            sqls.DMLQuery("select idregistrasi,registrasino,convert(varchar,registrasidate,105) + ' ' + convert(varchar,registrasidate,108) as registrasidate,idrekammedis from registrasi where idregistrasi='" & idselectu & "'", "getid")
            Dim idregu As String = CStr(sqls.getDataSet("getid", 0, "idregistrasi"))
            Dim strnodata As String = sqls.getDataSet("getid", 0, "registrasino")
            Dim strregdate As String = sqls.getDataSet("getid", 0, "registrasidate")
            Dim idrmu As String = CStr(sqls.getDataSet("getid", 0, "idrekammedis"))

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idrmu})
            sqls.CallSP("spGetPasienRegistrasi", "getpasienreg", field, value)

            Dim strnama As String = sqls.getDataSet("getpasienreg", 0, "nama")
            Dim strjnskelamin As String = sqls.getDataSet("getpasienreg", 0, "jeniskelamin")
            Dim strnorm As String = sqls.getDataSet("getpasienreg", 0, "rekammedisno")
            Dim strTglLahir As String = sqls.getDataSet("getpasienreg", 0, "tanggallahir")
            Dim dtTglLahir = Strdate2Date(strTglLahir)
            Dim strUmur As String = sqls.getDataSet("getpasienreg", 0, "usia")
            Dim idjnskelamin As String = sqls.getDataSet("getpasienreg", 0, "idjeniskelamin")

            Dim lstdata As New List(Of String)
            lstdata.Add(idregu)
            lstdata.Add(strnama)
            lstdata.Add(strnorm)
            lstdata.Add("Tgl. Lahir " & dtTglLahir.Day & " " & NamaBulan(dtTglLahir.Month) & " " & dtTglLahir.Year)
            lstdata.Add(strnodata)
            lstdata.Add("Umur " & strUmur)
            lstdata.Add(strregdate)
            lstdata.Add(strjnskelamin)

            'Dim prntname As String = ""
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            'If sd.ShowDialog() = DialogResult.OK Then
            '    prntname = sd.getdevicename
            Dim selectWB As New frmWristbandSelect
            tambahChild(selectWB)
            selectWB.ShowDialog()
            If selectWB.getStringPilih = "Dewasa" Then
                If idjnskelamin = "0" Then
                    Dim sharename As String = getPrinter("WRBAF")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                    End If
                Else
                    Dim sharename As String = getPrinter("WRBAM")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                    End If
                End If
            ElseIf selectWB.getStringPilih = "Anak" Then
                Dim sharename As String = getPrinter("WRBB")
                If sharename <> "" Then
                    cetakWristband(lstdata, sharename)
                Else
                    dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                End If
            End If
            'End If
            'cetakWristband(lstdata, "")
        End If
    End Sub

    Private Sub btnAntrianMin_Click(sender As Object, e As EventArgs) Handles btnAntrianMin.Click
        If btnAntrianMin.Tag = "Max" Then
            gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - gcAntrian.Size.Height)
            btnAntrianMin.Tag = "Min"
        Else
            gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - ((gcAntrian.Size.Height - tlpAntrian.Size.Height) + lblAntrian.Size.Height - 2))
            btnAntrianMin.Tag = "Max"
        End If
    End Sub


    Private Sub btnoRadiologi_Click(sender As Object, e As EventArgs) Handles btnoRadiologi.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment,idunit from registrasi where idregistrasi='" & idselect & "'", "getiddeptunit")
        Dim idtmpunit As String = sqls.getDataSet("getiddeptunit", 0, "idunit")
        Dim idtmpdept As String = sqls.getDataSet("getiddeptunit", 0, "iddepartment")
        Dim frmOrder As New frmOrderRadiologi(idtmpunit, idtmpdept, idselect)
        tambahChild(frmOrder)
        frmOrder.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.StartPosition = FormStartPosition.CenterScreen
        frmOrder.pMinimize.Enabled = False
        frmOrder.pMaximize.Enabled = False
        frmOrder.tlpForm.RowCount = 4
        frmOrder.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmOrder.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnoLaborat_Click(sender As Object, e As EventArgs) Handles btnoLaborat.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment,idunit from registrasi where idregistrasi='" & idselect & "'", "getiddeptunit")
        Dim idtmpunit As String = sqls.getDataSet("getiddeptunit", 0, "idunit")
        Dim idtmpdept As String = sqls.getDataSet("getiddeptunit", 0, "iddepartment")
        Dim frmOrder As New frmOrderLaboratorium(idtmpunit, idtmpdept, idselect)
        tambahChild(frmOrder)
        frmOrder.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.StartPosition = FormStartPosition.CenterScreen
        frmOrder.pMinimize.Enabled = False
        frmOrder.pMaximize.Enabled = False
        frmOrder.tlpForm.RowCount = 4
        frmOrder.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmOrder.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnInfoPasien_Click(sender As Object, e As EventArgs) Handles btnInfoPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frminfopx As New frmInfoPasien(teNoRM.Tag)
        tambahChild(frminfopx)
        frminfopx.StartPosition = FormStartPosition.CenterScreen
        frminfopx.pMinimize.Enabled = False
        frminfopx.pMaximize.Enabled = False
        frminfopx.tlpForm.RowCount = 4
        frminfopx.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frminfopx.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

End Class