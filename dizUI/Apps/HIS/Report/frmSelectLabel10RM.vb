Imports System.ComponentModel

Public Class frmSelectLabel10RM

    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click, btnSelect2.Click, btnSelect3.Click, btnSelect4.Click, btnSelect5.Click, btnSelect6.Click, btnSelect7.Click, btnSelect8.Click, btnSelect9.Click, btnSelect10.Click
        If teSearch.Text = "" Then Exit Sub

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select rm.idrekammedis as ID,dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl. Lahir' from rekammedis rm left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' where rm.isdeleted=0 and (rm.nama like '%" & teSearch.Text & "%' or rm.rekammedisno like '%" & teSearch.Text & "%') order by rm.nama asc", "search")

        Dim cari As New frmSearch(sqls.dataSet, "search", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = cari.GetIDSelectData

            Dim mys As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            mys.DMLQuery("select rm.idrekammedis as id,dbo.fformatnorm(rm.rekammedisno) as norm,rm.nama as 'namapasien',jk.generalcode as sex,convert(varchar,rm.tanggallahir,105) as 'tanggallahir' from rekammedis rm left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' where rm.idrekammedis='" & idselectu & "'", "getrm")

            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {idselectu, mys.getDataSet("getrm", 0, "norm"), mys.getDataSet("getrm", 0, "namapasien"), mys.getDataSet("getrm", 0, "sex"), mys.getDataSet("getrm", 0, "tanggallahir")})

            CType(sender, System.Windows.Forms.Button).Tag = String.Join("|", strLbl)
            CType(sender, System.Windows.Forms.Button).Text = mys.getDataSet("getrm", 0, "norm") & vbCrLf & mys.getDataSet("getrm", 0, "namapasien")

            teSearch.Text = ""
        Else
            Dim strLbl As New List(Of String)
            strLbl.AddRange(New String() {"", "", "", "", ""})
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
        Dim rpt As New xrLabelPasienRM18815_201901
        rpt.RequestParameters = False
        'rpt.Parameters("pTglLahir").Value = mys.getDataSet("regslip", 0, "tanggallahir")
        rpt.DisplayName = "Cetak Label 10"
        rpt.ShowPrintMarginsWarning = False

        rpt.p1ID.Value = btnSelect1.Tag.ToString.Split("|")(0)
        rpt.p1NoRM.Value = btnSelect1.Tag.ToString.Split("|")(1)
        rpt.p1Nama.Value = btnSelect1.Tag.ToString.Split("|")(2)
        rpt.p1Sex.Value = btnSelect1.Tag.ToString.Split("|")(3)
        rpt.p1TglLahir.Value = btnSelect1.Tag.ToString.Split("|")(4)

        rpt.p2ID.Value = btnSelect2.Tag.ToString.Split("|")(0)
        rpt.p2NoRM.Value = btnSelect2.Tag.ToString.Split("|")(1)
        rpt.p2Nama.Value = btnSelect2.Tag.ToString.Split("|")(2)
        rpt.p2Sex.Value = btnSelect2.Tag.ToString.Split("|")(3)
        rpt.p2TglLahir.Value = btnSelect2.Tag.ToString.Split("|")(4)

        rpt.p3ID.Value = btnSelect3.Tag.ToString.Split("|")(0)
        rpt.p3NoRM.Value = btnSelect3.Tag.ToString.Split("|")(1)
        rpt.p3Nama.Value = btnSelect3.Tag.ToString.Split("|")(2)
        rpt.p3Sex.Value = btnSelect3.Tag.ToString.Split("|")(3)
        rpt.p3TglLahir.Value = btnSelect3.Tag.ToString.Split("|")(4)

        rpt.p4ID.Value = btnSelect4.Tag.ToString.Split("|")(0)
        rpt.p4NoRM.Value = btnSelect4.Tag.ToString.Split("|")(1)
        rpt.p4Nama.Value = btnSelect4.Tag.ToString.Split("|")(2)
        rpt.p4Sex.Value = btnSelect4.Tag.ToString.Split("|")(3)
        rpt.p4TglLahir.Value = btnSelect4.Tag.ToString.Split("|")(4)

        rpt.p5ID.Value = btnSelect5.Tag.ToString.Split("|")(0)
        rpt.p5NoRM.Value = btnSelect5.Tag.ToString.Split("|")(1)
        rpt.p5Nama.Value = btnSelect5.Tag.ToString.Split("|")(2)
        rpt.p5Sex.Value = btnSelect5.Tag.ToString.Split("|")(3)
        rpt.p5TglLahir.Value = btnSelect5.Tag.ToString.Split("|")(4)

        rpt.p6ID.Value = btnSelect6.Tag.ToString.Split("|")(0)
        rpt.p6NoRM.Value = btnSelect6.Tag.ToString.Split("|")(1)
        rpt.p6Nama.Value = btnSelect6.Tag.ToString.Split("|")(2)
        rpt.p6Sex.Value = btnSelect6.Tag.ToString.Split("|")(3)
        rpt.p6TglLahir.Value = btnSelect6.Tag.ToString.Split("|")(4)

        rpt.p7ID.Value = btnSelect7.Tag.ToString.Split("|")(0)
        rpt.p7NoRM.Value = btnSelect7.Tag.ToString.Split("|")(1)
        rpt.p7Nama.Value = btnSelect7.Tag.ToString.Split("|")(2)
        rpt.p7Sex.Value = btnSelect7.Tag.ToString.Split("|")(3)
        rpt.p7TglLahir.Value = btnSelect7.Tag.ToString.Split("|")(4)

        rpt.p8ID.Value = btnSelect8.Tag.ToString.Split("|")(0)
        rpt.p8NoRM.Value = btnSelect8.Tag.ToString.Split("|")(1)
        rpt.p8Nama.Value = btnSelect8.Tag.ToString.Split("|")(2)
        rpt.p8Sex.Value = btnSelect8.Tag.ToString.Split("|")(3)
        rpt.p8TglLahir.Value = btnSelect8.Tag.ToString.Split("|")(4)

        rpt.p9ID.Value = btnSelect9.Tag.ToString.Split("|")(0)
        rpt.p9NoRM.Value = btnSelect9.Tag.ToString.Split("|")(1)
        rpt.p9Nama.Value = btnSelect9.Tag.ToString.Split("|")(2)
        rpt.p9Sex.Value = btnSelect9.Tag.ToString.Split("|")(3)
        rpt.p9TglLahir.Value = btnSelect9.Tag.ToString.Split("|")(4)

        rpt.p10ID.Value = btnSelect10.Tag.ToString.Split("|")(0)
        rpt.p10NoRM.Value = btnSelect10.Tag.ToString.Split("|")(1)
        rpt.p10Nama.Value = btnSelect10.Tag.ToString.Split("|")(2)
        rpt.p10Sex.Value = btnSelect10.Tag.ToString.Split("|")(3)
        rpt.p10TglLahir.Value = btnSelect10.Tag.ToString.Split("|")(4)

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
        strLbl.AddRange(New String() {"", "", "", "", ""})

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

        teSearch.Text = ""
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

End Class