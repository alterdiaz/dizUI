Public Class frmSelectLabel6
    Public Sub New(Optional param As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strdept = param
    End Sub

    Private strdept As String = ""
    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click, btnSelect2.Click, btnSelect3.Click, btnSelect4.Click, btnSelect5.Click, btnSelect6.Click
        Dim sqls As New SQLs(dbstring)
        If strdept = "" Then
            sqls.DMLQuery("Select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105) order by r.registrasidate desc", "search")
        Else
            sqls.DMLQuery("Select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.iddepartment in (select value from sys_appsetting where variable='" & strdept & "') and r.registrasistatus=0 and rm.rekammedisno<>0 and convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105) order by r.registrasidate desc", "search")
        End If
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = cari.GetIDSelectData

            Dim mys As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idreg"})
            value.AddRange(New Object() {idselectu})
            mys.CallSP("spRegistrasiSlip", "regslip", field, value, 1)

            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {idselectu, mys.getDataSet("regslip", 0, "namapasien"), mys.getDataSet("regslip", 0, "sex"), mys.getDataSet("regslip", 0, "tanggallahir"), mys.getDataSet("regslip", 0, "umur"), mys.getDataSet("regslip", 0, "registrasidate"), mys.getDataSet("regslip", 0, "paramedis")})

            CType(sender, System.Windows.Forms.Button).Tag = String.Join("|", strLbl)
            CType(sender, System.Windows.Forms.Button).Text = mys.getDataSet("regslip", 0, "regno") & vbCrLf & mys.getDataSet("regslip", 0, "namapasien")
        Else
            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {"", "", "", "", "", "", ""})
            CType(sender, System.Windows.Forms.Button).Tag = String.Join("|", strLbl)

            If sender Is btnSelect1 Then
                CType(sender, System.Windows.Forms.Button).Text = "1"
            ElseIf sender Is btnSelect2 Then
                CType(sender, System.Windows.Forms.Button).Text = "2"
            ElseIf sender Is btnSelect3 Then
                CType(sender, System.Windows.Forms.Button).Text = "3"
            ElseIf sender Is btnSelect4 Then
                CType(sender, System.Windows.Forms.Button).Text = "4"
            ElseIf sender Is btnSelect5 Then
                CType(sender, System.Windows.Forms.Button).Text = "5"
            ElseIf sender Is btnSelect6 Then
                CType(sender, System.Windows.Forms.Button).Text = "6"
            End If
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
     ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim prntname As String = ""
        'Dim sd As New frmSelectDevice
        'tambahChild(sd)
        'If sd.ShowDialog() = DialogResult.OK Then
        '    prntname = sd.getdevicename
        Dim rpt As New xrLabelPasien16212_201901
        rpt.RequestParameters = False
        'rpt.Parameters("pTglLahir").Value = mys.getDataSet("regslip", 0, "tanggallahir")
        rpt.DisplayName = "Cetak Label 6"
        rpt.ShowPrintMarginsWarning = False

        rpt.p1Nama.Value = btnSelect1.Tag.ToString.Split("|")(1)
        rpt.p1Sex.Value = btnSelect1.Tag.ToString.Split("|")(2)
        rpt.p1TglLahir.Value = IIf(btnSelect1.Tag.ToString.Split("|")(3) = "", "", btnSelect1.Tag.ToString.Split("|")(3) & " (" & btnSelect1.Tag.ToString.Split("|")(4) & ")")
        rpt.p1TglReg.Value = btnSelect1.Tag.ToString.Split("|")(5)
        rpt.p1Paramedis.Value = btnSelect1.Tag.ToString.Split("|")(6)

        rpt.p2Nama.Value = btnSelect2.Tag.ToString.Split("|")(1)
        rpt.p2Sex.Value = btnSelect2.Tag.ToString.Split("|")(2)
        rpt.p2TglLahir.Value = IIf(btnSelect2.Tag.ToString.Split("|")(3) = "", "", btnSelect2.Tag.ToString.Split("|")(3) & " (" & btnSelect2.Tag.ToString.Split("|")(4) & ")")
        rpt.p2TglReg.Value = btnSelect2.Tag.ToString.Split("|")(5)
        rpt.p2Paramedis.Value = btnSelect2.Tag.ToString.Split("|")(6)

        rpt.p3Nama.Value = btnSelect3.Tag.ToString.Split("|")(1)
        rpt.p3Sex.Value = btnSelect3.Tag.ToString.Split("|")(2)
        rpt.p3TglLahir.Value = IIf(btnSelect3.Tag.ToString.Split("|")(3) = "", "", btnSelect3.Tag.ToString.Split("|")(3) & " (" & btnSelect3.Tag.ToString.Split("|")(4) & ")")
        rpt.p3TglReg.Value = btnSelect3.Tag.ToString.Split("|")(5)
        rpt.p3Paramedis.Value = btnSelect3.Tag.ToString.Split("|")(6)

        rpt.p4Nama.Value = btnSelect4.Tag.ToString.Split("|")(1)
        rpt.p4Sex.Value = btnSelect4.Tag.ToString.Split("|")(2)
        rpt.p4TglLahir.Value = IIf(btnSelect4.Tag.ToString.Split("|")(3) = "", "", btnSelect4.Tag.ToString.Split("|")(3) & " (" & btnSelect4.Tag.ToString.Split("|")(4) & ")")
        rpt.p4TglReg.Value = btnSelect4.Tag.ToString.Split("|")(5)
        rpt.p4Paramedis.Value = btnSelect4.Tag.ToString.Split("|")(6)

        rpt.p5Nama.Value = btnSelect5.Tag.ToString.Split("|")(1)
        rpt.p5Sex.Value = btnSelect5.Tag.ToString.Split("|")(2)
        rpt.p5TglLahir.Value = IIf(btnSelect5.Tag.ToString.Split("|")(3) = "", "", btnSelect5.Tag.ToString.Split("|")(3) & " (" & btnSelect5.Tag.ToString.Split("|")(4) & ")")
        rpt.p5TglReg.Value = btnSelect5.Tag.ToString.Split("|")(5)
        rpt.p5Paramedis.Value = btnSelect5.Tag.ToString.Split("|")(6)

        rpt.p6Nama.Value = btnSelect6.Tag.ToString.Split("|")(1)
        rpt.p6Sex.Value = btnSelect6.Tag.ToString.Split("|")(2)
        rpt.p6TglLahir.Value = IIf(btnSelect6.Tag.ToString.Split("|")(3) = "", "", btnSelect6.Tag.ToString.Split("|")(3) & " (" & btnSelect6.Tag.ToString.Split("|")(4) & ")")
        rpt.p6TglReg.Value = btnSelect6.Tag.ToString.Split("|")(5)
        rpt.p6Paramedis.Value = btnSelect6.Tag.ToString.Split("|")(6)

        'rpt.PrinterName = prntname
        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load

        Dim sharename As String = getPrinter("REGLBLMULTI")
        If sharename <> "" Then
            Try
                pt.Print(sharename)
            Catch ex As Exception
                dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan, Me)
            End Try
        Else
            dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
        End If

        'pt.Print(prntname)
        'prntname = sd.getdevicename
        'pt.Print(prntname)
        'End If
    End Sub

    Private Sub frmSelectRadiologi6_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strLbl As New List(Of String)
        strLbl.AddRange(New String() {"", "", "", "", "", "", ""})

        btnSelect1.Tag = String.Join("|", strLbl)
        btnSelect2.Tag = String.Join("|", strLbl)
        btnSelect3.Tag = String.Join("|", strLbl)
        btnSelect4.Tag = String.Join("|", strLbl)
        btnSelect5.Tag = String.Join("|", strLbl)
        btnSelect6.Tag = String.Join("|", strLbl)

        btnSelect1.Text = "1"
        btnSelect2.Text = "2"
        btnSelect3.Text = "3"
        btnSelect4.Text = "4"
        btnSelect5.Text = "5"
        btnSelect6.Text = "6"

        If strdept <> "" Then
            strdept = "ID" & strdept & "Dept"
        End If
    End Sub

    Private Sub ceAllButton_CheckedChanged(sender As Object, e As EventArgs) Handles ceAllButton.CheckedChanged
        If btnSelect1.Text = "1" Then
            dizMsgbox("Button 1 belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If ceAllButton.CheckState = CheckState.Checked Then
            btnSelect2.Tag = btnSelect1.Tag
            btnSelect3.Tag = btnSelect1.Tag
            btnSelect4.Tag = btnSelect1.Tag
            btnSelect5.Tag = btnSelect1.Tag
            btnSelect6.Tag = btnSelect1.Tag

            btnSelect2.Text = btnSelect1.Text
            btnSelect3.Text = btnSelect1.Text
            btnSelect4.Text = btnSelect1.Text
            btnSelect5.Text = btnSelect1.Text
            btnSelect6.Text = btnSelect1.Text
        Else
            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {"", "", "", "", "", "", ""})

            btnSelect2.Tag = String.Join("|", strLbl)
            btnSelect3.Tag = String.Join("|", strLbl)
            btnSelect4.Tag = String.Join("|", strLbl)
            btnSelect5.Tag = String.Join("|", strLbl)
            btnSelect6.Tag = String.Join("|", strLbl)

            btnSelect2.Text = "2"
            btnSelect3.Text = "3"
            btnSelect4.Text = "4"
            btnSelect5.Text = "5"
            btnSelect6.Text = "6"
        End If
    End Sub

End Class