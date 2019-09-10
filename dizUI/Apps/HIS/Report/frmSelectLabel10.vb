Imports System.ComponentModel

Public Class frmSelectLabel10
    Public Sub New(Optional param As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strdept = param
    End Sub

    Private strdept As String = ""
    Private listBool As New List(Of Boolean)
    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click, btnSelect2.Click, btnSelect3.Click, btnSelect4.Click, btnSelect5.Click, btnSelect6.Click, btnSelect7.Click, btnSelect8.Click, btnSelect9.Click, btnSelect10.Click
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
            strLbl.AddRange(New String() {idselectu, mys.getDataSet("regslip", 0, "namapasien"), mys.getDataSet("regslip", 0, "sex"), mys.getDataSet("regslip", 0, "tanggallahir"), mys.getDataSet("regslip", 0, "umur"), mys.getDataSet("regslip", 0, "registrasidate"), mys.getDataSet("regslip", 0, "paramedis"), mys.getDataSet("regslip", 0, "norm"), mys.getDataSet("regslip", 0, "regno")})

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
            ElseIf sender Is btnSelect7 Then
                CType(sender, System.Windows.Forms.Button).Text = "7"
            ElseIf sender Is btnSelect8 Then
                CType(sender, System.Windows.Forms.Button).Text = "8"
            ElseIf sender Is btnSelect9 Then
                CType(sender, System.Windows.Forms.Button).Text = "9"
            ElseIf sender Is btnSelect10 Then
                CType(sender, System.Windows.Forms.Button).Text = "10"
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
        Dim rpt As New xrLabelPasien18815_201801
        rpt.RequestParameters = False
        'rpt.Parameters("pTglLahir").Value = mys.getDataSet("regslip", 0, "tanggallahir")
        rpt.DisplayName = "Cetak Label 10"
        rpt.ShowPrintMarginsWarning = False

        rpt.p1NoRM.Value = btnSelect1.Tag.ToString.Split("|")(7)
        rpt.p1NoReg.Value = btnSelect1.Tag.ToString.Split("|")(8)
        rpt.p1Nama.Value = btnSelect1.Tag.ToString.Split("|")(1)
        rpt.p1Sex.Value = btnSelect1.Tag.ToString.Split("|")(2)
        rpt.p1TglLahir.Value = IIf(btnSelect1.Tag.ToString.Split("|")(3) = "", "", btnSelect1.Tag.ToString.Split("|")(3) & " (" & btnSelect1.Tag.ToString.Split("|")(4) & ")")
        rpt.p1TglReg.Value = btnSelect1.Tag.ToString.Split("|")(5)
        If listBool.Item(0) = True Then
            rpt.p1Paramedis.Value = btnSelect1.Tag.ToString.Split("|")(6)
        Else
            rpt.p1Paramedis.Value = ""
        End If

        rpt.p2NoRM.Value = btnSelect2.Tag.ToString.Split("|")(7)
        rpt.p2NoReg.Value = btnSelect2.Tag.ToString.Split("|")(8)
        rpt.p2Nama.Value = btnSelect2.Tag.ToString.Split("|")(1)
        rpt.p2Sex.Value = btnSelect2.Tag.ToString.Split("|")(2)
        rpt.p2TglLahir.Value = IIf(btnSelect2.Tag.ToString.Split("|")(3) = "", "", btnSelect2.Tag.ToString.Split("|")(3) & " (" & btnSelect2.Tag.ToString.Split("|")(4) & ")")
        rpt.p2TglReg.Value = btnSelect2.Tag.ToString.Split("|")(5)
        If listBool.Item(1) = True Then
            rpt.p2Paramedis.Value = btnSelect2.Tag.ToString.Split("|")(6)
        Else
            rpt.p2Paramedis.Value = ""
        End If

        rpt.p3NoRM.Value = btnSelect3.Tag.ToString.Split("|")(7)
        rpt.p3NoReg.Value = btnSelect3.Tag.ToString.Split("|")(8)
        rpt.p3Nama.Value = btnSelect3.Tag.ToString.Split("|")(1)
        rpt.p3Sex.Value = btnSelect3.Tag.ToString.Split("|")(2)
        rpt.p3TglLahir.Value = IIf(btnSelect3.Tag.ToString.Split("|")(3) = "", "", btnSelect3.Tag.ToString.Split("|")(3) & " (" & btnSelect3.Tag.ToString.Split("|")(4) & ")")
        rpt.p3TglReg.Value = btnSelect3.Tag.ToString.Split("|")(5)
        If listBool.Item(2) = True Then
            rpt.p3Paramedis.Value = btnSelect3.Tag.ToString.Split("|")(6)
        Else
            rpt.p3Paramedis.Value = ""
        End If

        rpt.p4NoRM.Value = btnSelect4.Tag.ToString.Split("|")(7)
        rpt.p4NoReg.Value = btnSelect4.Tag.ToString.Split("|")(8)
        rpt.p4Nama.Value = btnSelect4.Tag.ToString.Split("|")(1)
        rpt.p4Sex.Value = btnSelect4.Tag.ToString.Split("|")(2)
        rpt.p4TglLahir.Value = IIf(btnSelect4.Tag.ToString.Split("|")(3) = "", "", btnSelect4.Tag.ToString.Split("|")(3) & " (" & btnSelect4.Tag.ToString.Split("|")(4) & ")")
        rpt.p4TglReg.Value = btnSelect4.Tag.ToString.Split("|")(5)
        If listBool.Item(3) = True Then
            rpt.p4Paramedis.Value = btnSelect4.Tag.ToString.Split("|")(6)
        Else
            rpt.p4Paramedis.Value = ""
        End If

        rpt.p5NoRM.Value = btnSelect5.Tag.ToString.Split("|")(7)
        rpt.p5NoReg.Value = btnSelect5.Tag.ToString.Split("|")(8)
        rpt.p5Nama.Value = btnSelect5.Tag.ToString.Split("|")(1)
        rpt.p5Sex.Value = btnSelect5.Tag.ToString.Split("|")(2)
        rpt.p5TglLahir.Value = IIf(btnSelect5.Tag.ToString.Split("|")(3) = "", "", btnSelect5.Tag.ToString.Split("|")(3) & " (" & btnSelect5.Tag.ToString.Split("|")(4) & ")")
        rpt.p5TglReg.Value = btnSelect5.Tag.ToString.Split("|")(5)
        If listBool.Item(4) = True Then
            rpt.p5Paramedis.Value = btnSelect5.Tag.ToString.Split("|")(6)
        Else
            rpt.p5Paramedis.Value = ""
        End If

        rpt.p6NoRM.Value = btnSelect6.Tag.ToString.Split("|")(7)
        rpt.p6NoReg.Value = btnSelect6.Tag.ToString.Split("|")(8)
        rpt.p6Nama.Value = btnSelect6.Tag.ToString.Split("|")(1)
        rpt.p6Sex.Value = btnSelect6.Tag.ToString.Split("|")(2)
        rpt.p6TglLahir.Value = IIf(btnSelect6.Tag.ToString.Split("|")(3) = "", "", btnSelect6.Tag.ToString.Split("|")(3) & " (" & btnSelect6.Tag.ToString.Split("|")(4) & ")")
        rpt.p6TglReg.Value = btnSelect6.Tag.ToString.Split("|")(5)
        If listBool.Item(5) = True Then
            rpt.p6Paramedis.Value = btnSelect6.Tag.ToString.Split("|")(6)
        Else
            rpt.p6Paramedis.Value = ""
        End If

        rpt.p7NoRM.Value = btnSelect7.Tag.ToString.Split("|")(7)
        rpt.p7NoReg.Value = btnSelect7.Tag.ToString.Split("|")(8)
        rpt.p7Nama.Value = btnSelect7.Tag.ToString.Split("|")(1)
        rpt.p7Sex.Value = btnSelect7.Tag.ToString.Split("|")(2)
        rpt.p7TglLahir.Value = IIf(btnSelect7.Tag.ToString.Split("|")(3) = "", "", btnSelect7.Tag.ToString.Split("|")(3) & " (" & btnSelect7.Tag.ToString.Split("|")(4) & ")")
        rpt.p7TglReg.Value = btnSelect7.Tag.ToString.Split("|")(5)
        If listBool.Item(6) = True Then
            rpt.p7Paramedis.Value = btnSelect7.Tag.ToString.Split("|")(6)
        Else
            rpt.p7Paramedis.Value = ""
        End If

        rpt.p8NoRM.Value = btnSelect8.Tag.ToString.Split("|")(7)
        rpt.p8NoReg.Value = btnSelect8.Tag.ToString.Split("|")(8)
        rpt.p8Nama.Value = btnSelect8.Tag.ToString.Split("|")(1)
        rpt.p8Sex.Value = btnSelect8.Tag.ToString.Split("|")(2)
        rpt.p8TglLahir.Value = IIf(btnSelect8.Tag.ToString.Split("|")(3) = "", "", btnSelect8.Tag.ToString.Split("|")(3) & " (" & btnSelect8.Tag.ToString.Split("|")(4) & ")")
        rpt.p8TglReg.Value = btnSelect8.Tag.ToString.Split("|")(5)
        If listBool.Item(7) = True Then
            rpt.p8Paramedis.Value = btnSelect8.Tag.ToString.Split("|")(6)
        Else
            rpt.p8Paramedis.Value = ""
        End If

        rpt.p9NoRM.Value = btnSelect9.Tag.ToString.Split("|")(7)
        rpt.p9NoReg.Value = btnSelect9.Tag.ToString.Split("|")(8)
        rpt.p9Nama.Value = btnSelect9.Tag.ToString.Split("|")(1)
        rpt.p9Sex.Value = btnSelect9.Tag.ToString.Split("|")(2)
        rpt.p9TglLahir.Value = IIf(btnSelect9.Tag.ToString.Split("|")(3) = "", "", btnSelect9.Tag.ToString.Split("|")(3) & " (" & btnSelect9.Tag.ToString.Split("|")(4) & ")")
        rpt.p9TglReg.Value = btnSelect9.Tag.ToString.Split("|")(5)
        If listBool.Item(8) = True Then
            rpt.p9Paramedis.Value = btnSelect9.Tag.ToString.Split("|")(6)
        Else
            rpt.p9Paramedis.Value = ""
        End If

        rpt.p10NoRM.Value = btnSelect10.Tag.ToString.Split("|")(7)
        rpt.p10NoReg.Value = btnSelect10.Tag.ToString.Split("|")(8)
        rpt.p10Nama.Value = btnSelect10.Tag.ToString.Split("|")(1)
        rpt.p10Sex.Value = btnSelect10.Tag.ToString.Split("|")(2)
        rpt.p10TglLahir.Value = IIf(btnSelect10.Tag.ToString.Split("|")(3) = "", "", btnSelect10.Tag.ToString.Split("|")(3) & " (" & btnSelect10.Tag.ToString.Split("|")(4) & ")")
        rpt.p10TglReg.Value = btnSelect10.Tag.ToString.Split("|")(5)
        If listBool.Item(9) = True Then
            rpt.p10Paramedis.Value = btnSelect10.Tag.ToString.Split("|")(6)
        Else
            rpt.p10Paramedis.Value = ""
        End If

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
        strLbl.AddRange(New String() {"", "", "", "", "", "", "", "", ""})

        btnSelect1.Tag = String.Join("|", strLbl)
        btnSelect2.Tag = String.Join("|", strLbl)
        btnSelect3.Tag = String.Join("|", strLbl)
        btnSelect4.Tag = String.Join("|", strLbl)
        btnSelect5.Tag = String.Join("|", strLbl)
        btnSelect6.Tag = String.Join("|", strLbl)
        btnSelect7.Tag = String.Join("|", strLbl)
        btnSelect8.Tag = String.Join("|", strLbl)
        btnSelect9.Tag = String.Join("|", strLbl)
        btnSelect10.Tag = String.Join("|", strLbl)

        btnSelect1.Text = "1"
        btnSelect2.Text = "2"
        btnSelect3.Text = "3"
        btnSelect4.Text = "4"
        btnSelect5.Text = "5"
        btnSelect6.Text = "6"
        btnSelect7.Text = "7"
        btnSelect8.Text = "8"
        btnSelect9.Text = "9"
        btnSelect10.Text = "10"

        listBool.AddRange(New Boolean() {False, False, False, False, False, False, False, False, False, False})
        tsmParamedis1.Checked = listBool.Item(0)
        tsmParamedis2.Checked = listBool.Item(1)
        tsmParamedis3.Checked = listBool.Item(2)
        tsmParamedis4.Checked = listBool.Item(3)
        tsmParamedis5.Checked = listBool.Item(4)
        tsmParamedis6.Checked = listBool.Item(5)
        tsmParamedis7.Checked = listBool.Item(6)
        tsmParamedis8.Checked = listBool.Item(7)
        tsmParamedis9.Checked = listBool.Item(8)
        tsmParamedis10.Checked = listBool.Item(9)

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
            btnSelect7.Tag = btnSelect1.Tag
            btnSelect8.Tag = btnSelect1.Tag
            btnSelect9.Tag = btnSelect1.Tag
            btnSelect10.Tag = btnSelect1.Tag

            btnSelect2.Text = btnSelect1.Text
            btnSelect3.Text = btnSelect1.Text
            btnSelect4.Text = btnSelect1.Text
            btnSelect5.Text = btnSelect1.Text
            btnSelect6.Text = btnSelect1.Text
            btnSelect7.Text = btnSelect1.Text
            btnSelect8.Text = btnSelect1.Text
            btnSelect9.Text = btnSelect1.Text
            btnSelect10.Text = btnSelect1.Text
        Else
            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {"", "", "", "", "", "", ""})

            btnSelect2.Tag = String.Join("|", strLbl)
            btnSelect3.Tag = String.Join("|", strLbl)
            btnSelect4.Tag = String.Join("|", strLbl)
            btnSelect5.Tag = String.Join("|", strLbl)
            btnSelect6.Tag = String.Join("|", strLbl)
            btnSelect7.Tag = String.Join("|", strLbl)
            btnSelect8.Tag = String.Join("|", strLbl)
            btnSelect9.Tag = String.Join("|", strLbl)
            btnSelect10.Tag = String.Join("|", strLbl)

            btnSelect2.Text = "2"
            btnSelect3.Text = "3"
            btnSelect4.Text = "4"
            btnSelect5.Text = "5"
            btnSelect6.Text = "6"
            btnSelect7.Text = "7"
            btnSelect8.Text = "8"
            btnSelect9.Text = "9"
            btnSelect10.Text = "10"
        End If
    End Sub

    Private Sub tsmParamedis_CheckedChanged(sender As Object, e As EventArgs) Handles tsmParamedis1.CheckedChanged, tsmParamedis2.CheckedChanged, tsmParamedis3.CheckedChanged, tsmParamedis4.CheckedChanged, tsmParamedis5.CheckedChanged, tsmParamedis6.CheckedChanged, tsmParamedis7.CheckedChanged, tsmParamedis8.CheckedChanged, tsmParamedis9.CheckedChanged, tsmParamedis10.CheckedChanged
        listBool.Clear()
        listBool.AddRange(New Boolean() {tsmParamedis1.Checked, tsmParamedis2.Checked, tsmParamedis3.Checked, tsmParamedis4.Checked, tsmParamedis5.Checked, tsmParamedis6.Checked, tsmParamedis7.Checked, tsmParamedis8.Checked, tsmParamedis9.Checked, tsmParamedis10.Checked})

        If sender Is tsmParamedis1 Then
            tsmParamedis1.Checked = listBool.Item(0)
        ElseIf sender Is tsmParamedis2 Then
            tsmParamedis2.Checked = listBool.Item(1)
        ElseIf sender Is tsmParamedis3 Then
            tsmParamedis3.Checked = listBool.Item(2)
        ElseIf sender Is tsmParamedis4 Then
            tsmParamedis4.Checked = listBool.Item(3)
        ElseIf sender Is tsmParamedis5 Then
            tsmParamedis5.Checked = listBool.Item(4)
        ElseIf sender Is tsmParamedis6 Then
            tsmParamedis6.Checked = listBool.Item(5)
        ElseIf sender Is tsmParamedis7 Then
            tsmParamedis7.Checked = listBool.Item(6)
        ElseIf sender Is tsmParamedis8 Then
            tsmParamedis8.Checked = listBool.Item(7)
        ElseIf sender Is tsmParamedis9 Then
            tsmParamedis9.Checked = listBool.Item(8)
        ElseIf sender Is tsmParamedis10 Then
            tsmParamedis10.Checked = listBool.Item(9)
        End If
    End Sub

    Private isCek16 As Boolean = False
    Private Sub ce16button_CheckedChanged(sender As Object, e As EventArgs) Handles ce16button.CheckedChanged
        If isCek16 = True Then Exit Sub
        If btnSelect1.Text = "1" Then
            dizMsgbox("Button 1 belum dipilih", dizMsgboxStyle.Peringatan, Me)
            isCek16 = True
            ce16button.Checked = False
            isCek16 = False
            Exit Sub
        End If
        If btnSelect6.Text = "6" Then
            dizMsgbox("Button 6 belum dipilih", dizMsgboxStyle.Peringatan, Me)
            isCek16 = True
            ce16button.Checked = False
            isCek16 = False
            Exit Sub
        End If

        tsmParamedis1.Checked = ce16button.Checked
        tsmParamedis6.Checked = ce16button.Checked
        'tsmParamedis_CheckedChanged(tsmParamedis1, Nothing)
        'tsmParamedis_CheckedChanged(tsmParamedis6, Nothing)
    End Sub

End Class