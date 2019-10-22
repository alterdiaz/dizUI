Public Class frmSelectLabel10Item
    Private isbypass As Boolean = False
    Private iddata As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isbypass = True
    End Sub

    Public Sub New(Optional param As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isbypass = False
    End Sub

    Public Sub bypass(id As String)
        isbypass = True
        iddata = id
    End Sub

    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click, btnSelect2.Click, btnSelect3.Click, btnSelect4.Click, btnSelect5.Click, btnSelect6.Click, btnSelect7.Click, btnSelect8.Click, btnSelect9.Click, btnSelect10.Click
        Dim sqls As New SQLs(dbstring)
        If isbypass = False Then

            sqls.DMLQuery("select i.iditem,i.kode,i.kodeupc,ig.itemgrup,it.generalcode as itemtype,i.item,s.satuan from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' where i.itemtype in (1,2,8,11,14,15) order by it.generalcode asc,i.item asc", "search")
            Dim cari As New frmSearch(sqls.dataSet, "search", "iditem")
            tambahChild(cari)

            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim idselect As String = cari.GetIDSelectData

                Dim mys As New SQLs(dbstring)
                mys.DMLQuery("select i.iditem,i.kode,i.kodeupc,ig.itemgrup,it.generalcode as itemtype,i.item,s.satuan from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' where i.iditem='" & idselect & "'", "getitem")

                Dim strLbl As New List(Of String)
                strLbl.AddRange(New String() {idselect, mys.getDataSet("getitem", 0, "itemtype"), mys.getDataSet("getitem", 0, "item"), mys.getDataSet("getitem", 0, "satuan"), mys.getDataSet("getitem", 0, "kodeupc")})

                CType(sender, System.Windows.Forms.Button).Tag = String.Join("|", strLbl)
                CType(sender, System.Windows.Forms.Button).Text = mys.getDataSet("getitem", 0, "kode") & vbCrLf & mys.getDataSet("getitem", 0, "item")
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
        Else
            If iddata <> "" Then
                Dim idselect As String = iddata

                Dim mys As New SQLs(dbstring)
                mys.DMLQuery("select i.iditem,i.kode,i.kodeupc,ig.itemgrup,it.generalcode as itemtype,i.item,s.satuan from item i left join itemgrup ig on i.iditemgrup=ig.iditemgrup left join satuan s on i.idsatuan=s.idsatuan left join sys_generalcode it on i.itemtype=it.idgeneral and it.gctype='itemtype' where i.iditem='" & idselect & "'", "getitem")

                Dim strLbl As New List(Of String)
                strLbl.AddRange(New String() {idselect, mys.getDataSet("getitem", 0, "itemtype"), mys.getDataSet("getitem", 0, "item"), mys.getDataSet("getitem", 0, "satuan"), mys.getDataSet("getitem", 0, "kodeupc")})

                CType(sender, System.Windows.Forms.Button).Tag = String.Join("|", strLbl)
                CType(sender, System.Windows.Forms.Button).Text = mys.getDataSet("getitem", 0, "kode") & vbCrLf & mys.getDataSet("getitem", 0, "item")
            Else
                isbypass = False
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
        Dim rpt As New xrItem18815_201901
        rpt.RequestParameters = False
        'rpt.Parameters("pTglLahir").Value = mys.getDataSet("regslip", 0, "tanggallahir")
        rpt.DisplayName = "Cetak Label 10"
        rpt.ShowPrintMarginsWarning = False

        rpt.p1ID.Value = btnSelect1.Tag.ToString.Split("|")(0)
        rpt.p1ItemType.Value = btnSelect1.Tag.ToString.Split("|")(1)
        rpt.p1Nama.Value = btnSelect1.Tag.ToString.Split("|")(2)
        rpt.p1Satuan.Value = btnSelect1.Tag.ToString.Split("|")(3)
        rpt.p1UPC.Value = btnSelect1.Tag.ToString.Split("|")(4)

        rpt.p2ID.Value = btnSelect2.Tag.ToString.Split("|")(0)
        rpt.p2ItemType.Value = btnSelect2.Tag.ToString.Split("|")(1)
        rpt.p2Nama.Value = btnSelect2.Tag.ToString.Split("|")(2)
        rpt.p2Satuan.Value = btnSelect2.Tag.ToString.Split("|")(3)
        rpt.p2UPC.Value = btnSelect2.Tag.ToString.Split("|")(4)

        rpt.p3ID.Value = btnSelect3.Tag.ToString.Split("|")(0)
        rpt.p3ItemType.Value = btnSelect3.Tag.ToString.Split("|")(1)
        rpt.p3Nama.Value = btnSelect3.Tag.ToString.Split("|")(2)
        rpt.p3Satuan.Value = btnSelect3.Tag.ToString.Split("|")(3)
        rpt.p3UPC.Value = btnSelect3.Tag.ToString.Split("|")(4)

        rpt.p4ID.Value = btnSelect4.Tag.ToString.Split("|")(0)
        rpt.p4ItemType.Value = btnSelect4.Tag.ToString.Split("|")(1)
        rpt.p4Nama.Value = btnSelect4.Tag.ToString.Split("|")(2)
        rpt.p4Satuan.Value = btnSelect4.Tag.ToString.Split("|")(3)
        rpt.p4UPC.Value = btnSelect4.Tag.ToString.Split("|")(4)

        rpt.p5ID.Value = btnSelect5.Tag.ToString.Split("|")(0)
        rpt.p5ItemType.Value = btnSelect5.Tag.ToString.Split("|")(1)
        rpt.p5Nama.Value = btnSelect5.Tag.ToString.Split("|")(2)
        rpt.p5Satuan.Value = btnSelect5.Tag.ToString.Split("|")(3)
        rpt.p5UPC.Value = btnSelect5.Tag.ToString.Split("|")(4)

        rpt.p6ID.Value = btnSelect6.Tag.ToString.Split("|")(0)
        rpt.p6ItemType.Value = btnSelect6.Tag.ToString.Split("|")(1)
        rpt.p6Nama.Value = btnSelect6.Tag.ToString.Split("|")(2)
        rpt.p6Satuan.Value = btnSelect6.Tag.ToString.Split("|")(3)
        rpt.p6UPC.Value = btnSelect6.Tag.ToString.Split("|")(4)

        rpt.p7ID.Value = btnSelect7.Tag.ToString.Split("|")(0)
        rpt.p7ItemType.Value = btnSelect7.Tag.ToString.Split("|")(1)
        rpt.p7Nama.Value = btnSelect7.Tag.ToString.Split("|")(2)
        rpt.p7Satuan.Value = btnSelect7.Tag.ToString.Split("|")(3)
        rpt.p7UPC.Value = btnSelect7.Tag.ToString.Split("|")(4)

        rpt.p8ID.Value = btnSelect8.Tag.ToString.Split("|")(0)
        rpt.p8ItemType.Value = btnSelect8.Tag.ToString.Split("|")(1)
        rpt.p8Nama.Value = btnSelect8.Tag.ToString.Split("|")(2)
        rpt.p8Satuan.Value = btnSelect8.Tag.ToString.Split("|")(3)
        rpt.p8UPC.Value = btnSelect8.Tag.ToString.Split("|")(4)

        rpt.p9ID.Value = btnSelect9.Tag.ToString.Split("|")(0)
        rpt.p9ItemType.Value = btnSelect9.Tag.ToString.Split("|")(1)
        rpt.p9Nama.Value = btnSelect9.Tag.ToString.Split("|")(2)
        rpt.p9Satuan.Value = btnSelect9.Tag.ToString.Split("|")(3)
        rpt.p9UPC.Value = btnSelect9.Tag.ToString.Split("|")(4)

        rpt.p10ID.Value = btnSelect10.Tag.ToString.Split("|")(0)
        rpt.p10ItemType.Value = btnSelect10.Tag.ToString.Split("|")(1)
        rpt.p10Nama.Value = btnSelect10.Tag.ToString.Split("|")(2)
        rpt.p10Satuan.Value = btnSelect10.Tag.ToString.Split("|")(3)
        rpt.p10UPC.Value = btnSelect10.Tag.ToString.Split("|")(4)

        'rpt.PrinterName = prntname
        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load

        Dim sharename As String = getPrinter("ITEMLBLMULTI")
        If sharename <> "" Then
            Try
                pt.Print(sharename)
            Catch ex As Exception
                If isbypass = False Then
                    Try
                        pt.PrintDialog()
                    Catch ex1 As Exception
                        dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                    End Try
                    'dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan, Me)
                End If
            End Try
        Else
            If isbypass = False Then
                Try
                    pt.PrintDialog()
                Catch ex As Exception
                    dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan, Me)
                End Try
                'dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
            Else
                Try
                    pt.PrintDialog()
                Catch ex As Exception
                    dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan, Me)
                End Try
            End If
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

        If isbypass = True Then
            btnSelect1_Click(btnSelect1, Nothing)
            If btnSelect1.Tag <> "||||" Then
                ceAllButton.CheckState = CheckState.Checked

                Application.DoEvents()
                Threading.Thread.Sleep(100)
                btnOK_Click(btnOK, EventArgs.Empty)

                Application.DoEvents()
                Threading.Thread.Sleep(100)
                Me.Dispose()
            End If
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
            strLbl.AddRange(New String() {"", "", "", "", ""})

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