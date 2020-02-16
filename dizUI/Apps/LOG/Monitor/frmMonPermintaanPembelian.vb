Public Class frmMonPermintaanPembelian
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

    Dim dtset As DataSet
    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged, lueUnit.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If lueUnit.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = " "
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        'MsgBox(CDate(deTanggal.EditValue).Year & vbCrLf & CDate(deTanggal.EditValue).Month & vbCrLf & lueDepartment.EditValue & vbCrLf & lueUnit.EditValue)

        Try
            Dim sqls As New SQLs(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@tahun", "@bulan", "@idunit"})
            value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, lueUnit.EditValue})
            sqls.CallSP("spMonSPP", "parent", field, value)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"@tahun", "@bulan", "@idunit"})
            value2.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, lueUnit.EditValue})
            sqls.CallSP("spMonSPPdt", "child", field2, value2)
            Threading.Thread.Sleep(200)

            dtset = New DataSet
            dtset = sqls.dataSet
            Dim dret As DataRelation
            dret = dtset.Relations.Add("Detail", dtset.Tables("parent").Columns("idtransaksi"), dtset.Tables("child").Columns("idtransaksi"))
            Threading.Thread.Sleep(100)
            gcData.DataSource = dtset.Tables("parent")
            gcData.LevelTree.Nodes.Add("Detail", gvDetil)
            gvData.BestFitColumns()
            gvDetil.BestFitColumns()
            gvData.OptionsView.ColumnAutoWidth = True
            gvDetil.OptionsView.ColumnAutoWidth = True
            gvData.OptionsDetail.AllowOnlyOneMasterRowExpanded = False
            For i As Integer = 0 To gvData.RowCount - 1
                gvData.ExpandMasterRow(i, "Detail")
            Next

            'For i As Integer = 0 To gvData.RowCount - 1
            '    gvData.SetRowCellValue(i, GridColumn1, i + 1)
            'Next
            gvData.BestFitColumns()
            gvDetil.BestFitColumns()
            gvData.ViewCaption = "Permintaan Pembelian Barang - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year & " " & lueUnit.Text
        Catch ex As Exception
        End Try

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        lueUnit.EditValue = Nothing
        deTanggal.EditValue = Nothing
        gvData.ViewCaption = ""
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and idunit<>'0' and isdeleted=0", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.EditValue = Nothing
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gcData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("SPP tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Belum memilih SPP", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
        Dim idselect As String = dr("idtransaksi")
        Dim selectPrint As New frmPrintSelect()
        tambahChild(selectPrint)
        selectPrint.ShowDialog()

        If selectPrint.getStringPilih = "PREVIEW" Then
            cetakBerkas(idselect, cu.preview, "")
        ElseIf selectPrint.getStringPilih = "CETAK" Then
            Dim prntname As String = ""
            prntname = getPrinter("SPP")
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            'If sd.ShowDialog() = DialogResult.OK Then
            'prntname = sd.getdevicename
            cetakBerkas(idselect, cu.cetak, prntname)
            'End If
            'cetakBerkas(idselectu, cu.cetak, "")
        End If
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum

    Private Sub cetakBerkas(iddata As String, cetaktype As cu, Optional printername As String = "")
        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {lueUnit.EditValue})

        Dim mysUnit As New SQLs(dbstring)
        mysUnit.CallSP("spGetParentUnitGrup", "parentunit", field2, value2)
        value2.Clear()

        mysUnit.DMLQuery("select transaksistatus from transaksi where idtransaksi='" & iddata & "'", "transstat")

        If mysUnit.getDataSet("parentunit") > 0 Then
            Dim idparent As String = mysUnit.getDataSet("parentunit", 0, "idunit")
            value2.AddRange(New Object() {idparent})
        Else
            value2.AddRange(New Object() {lueUnit.EditValue})
        End If
        mysUnit.CallSP("spUnit", "unit", field2, value2)

        Dim mys As New SQLs(dbstring)
        Dim fieldctk As New List(Of String)
        Dim valuectk As New List(Of Object)
        fieldctk.AddRange(New String() {"@id"})
        valuectk.AddRange(New Object() {iddata})
        mys.CallSP("spSPPHD", "spSPPHD", fieldctk, valuectk)
        mys.CallSP("spSPPcurrent", "spSPPcurrent", fieldctk, valuectk)

        Dim rpt As New xrSPP
        'If mysUnit.getDataSet("transstat", 0, "transaksistatus") = "2" Then
        '    rpt.Watermark.Image = My.Resources.stampVoid
        '    rpt.Watermark.ImageAlign = ContentAlignment.MiddleCenter
        '    rpt.Watermark.ImageTiling = False
        '    rpt.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
        '    rpt.Watermark.ImageTransparency = 150
        '    rpt.Watermark.ShowBehind = True
        'ElseIf mysUnit.getDataSet("transstat", 0, "transaksistatus") = "6" Then
        '    rpt.Watermark.Image = My.Resources.stampReview
        '    rpt.Watermark.ImageAlign = ContentAlignment.MiddleCenter
        '    rpt.Watermark.ImageTiling = False
        '    rpt.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
        '    rpt.Watermark.ImageTransparency = 150
        '    rpt.Watermark.ShowBehind = True
        'ElseIf mysUnit.getDataSet("transstat", 0, "transaksistatus") = "3" Then
        '    rpt.Watermark.Image = My.Resources.stampAccept
        '    rpt.Watermark.ImageAlign = ContentAlignment.MiddleCenter
        '    rpt.Watermark.ImageTiling = False
        '    rpt.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
        '    rpt.Watermark.ImageTransparency = 150
        '    rpt.Watermark.ShowBehind = True
        'ElseIf mysUnit.getDataSet("transstat", 0, "transaksistatus") = "8" Then
        '    rpt.Watermark.Image = My.Resources.stampAccept
        '    rpt.Watermark.ImageAlign = ContentAlignment.MiddleCenter
        '    rpt.Watermark.ImageTiling = False
        '    rpt.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Clip
        '    rpt.Watermark.ImageTransparency = 150
        '    rpt.Watermark.ShowBehind = True
        'End If

        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "spSPPcurrent"
        rpt.DisplayName = "SPP"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pUnit").Value = mysUnit.getDataSet("unit", 0, "unit")
        rpt.Parameters("pNotes").Value = mysUnit.getDataSet("unit", 0, "notes")
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        If cetaktype = cu.cetak Then
            If printername = "" Then
                Try
                    pt.PrintDialog()
                Catch ex1 As Exception
                    dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                End Try
            Else
                Dim sharename As String = getPrinter("SPP")
                If sharename <> "" Then
                    Try
                        pt.Print(sharename)
                    Catch ex As Exception
                        Try
                            pt.PrintDialog()
                        Catch ex1 As Exception
                            dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                        End Try
                    End Try
                Else
                    Try
                        pt.PrintDialog()
                    Catch ex1 As Exception
                        dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                    End Try
                End If
            End If
        ElseIf cetaktype = cu.preview Then
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
      ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

End Class