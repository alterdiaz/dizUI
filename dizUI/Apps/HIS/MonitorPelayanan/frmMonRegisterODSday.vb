Public Class frmMonRegisterODSday
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

    Private Sub loadgrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"@tahun", "@bulan", "@tanggal"})
        value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month, CDate(deTanggal.EditValue).Day})
        sqls.CallSP("spMonRegisterODSDay", "monreg", field, value)
        gvData.ViewCaption = "Register ODS - " & CDate(deTanggal.EditValue).Day & " " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year

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
        GridColumn18.GroupIndex = 1
        gvData.ExpandAllGroups()
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
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub ribeASM_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ribeASM.ButtonClick
        If gvData.FocusedRowHandle >= 0 Then
            Dim idreg As String = 0
            Dim idasm As String = 0
            Dim noform As String = ""

            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            idreg = CStr(dr("idregistrasi"))
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select isasesmenmedis from registrasi where isasesmenmedis=1 and idregistrasi='" & idreg & "'", "cekasm")
            If sqls.getDataSet("cekasm") = 0 Then
                dizMsgbox("Belum dilakukan Assessment Medis", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            sqls.DMLQuery("select idassessment,nomorform from assessment where idregistrasi='" & idreg & "'", "getasm")
            idasm = CStr(sqls.getDataSet("getasm", 0, "idassessment"))
            noform = CStr(sqls.getDataSet("getasm", 0, "nomorform"))
            previewBerkasAMMCU(idasm, idreg, noform, cu.preview)
        End If
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum

    Private Sub previewBerkasAMMCU(iddata As String, idreg As String, nomorform As String, cetaktype As cu)
        If nomorform = "AMODS201801" Then
            AMODS201801(iddata, idreg, cetaktype)
        End If
    End Sub

    Private Sub AMODS201801(iddata As String, idreg As String, cetaktype As cu)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMODS201801", "asmods", field, value)

        Dim mysSOAP As New SQLs(dbstring)
        mysSOAP.CallSP("spSN201801", "soap", field2, value2)

        Dim mysAMU As New SQLs(dbstring)
        mysAMU.CallSP("spAMunit", "unit", field, value)

        Dim mysA As New SQLs(dbstring)
        mysA.CallSP("spRiwayatA201801", "a", field2, value2)

        Dim mysS As New SQLs(dbstring)
        mysS.CallSP("spRiwayatS201801", "s", field2, value2)

        Dim mysD As New SQLs(dbstring)
        mysD.CallSP("spRiwayatD201801", "d", field2, value2)

        Dim mysO As New SQLs(dbstring)
        mysO.CallSP("spRiwayatO201801", "o", field2, value2)

        Dim mysSNU As New SQLs(dbstring)
        mysSNU.CallSP("spSNunit", "unit", field2, value2)

        Dim mysAn As New SQLs(dbstring)
        mysAn.CallSP("spAnatomi", "anatomi", field2, value2)

        Dim mysE As New SQLs(dbstring)
        mysE.CallSP("spPenunjangEKG", "ekg", field2, value2)

        Dim mysL As New SQLs(dbstring)
        mysL.CallSP("spPenunjangLAB", "lab", field2, value2)

        Dim mysR As New SQLs(dbstring)
        mysR.CallSP("spPenunjangRAD", "rad", field2, value2)

        Dim mysP As New SQLs(dbstring)
        mysP.CallSP("spRegDPJP", "dpjp", field2, value2)

        Dim rptA As New xrRiwayatA201801
        rptA.RequestParameters = False
        rptA.DataAdapter = mysA.getDataAdapter
        rptA.DataSource = mysA.dataSet
        rptA.DataMember = "a"

        Dim rptS As New xrRiwayatS201801
        rptS.RequestParameters = False
        rptS.DataAdapter = mysS.getDataAdapter
        rptS.DataSource = mysS.dataSet
        rptS.DataMember = "s"

        Dim rptD As New xrRiwayatD201801
        rptD.RequestParameters = False
        rptD.DataAdapter = mysD.getDataAdapter
        rptD.DataSource = mysD.dataSet
        rptD.DataMember = "d"

        Dim rptO As New xrRiwayatO201801
        rptO.RequestParameters = False
        rptO.DataAdapter = mysO.getDataAdapter
        rptO.DataSource = mysO.dataSet
        rptO.DataMember = "o"

        Dim rptAn As New xrAnatomiSQ
        rptAn.RequestParameters = False
        rptAn.DataAdapter = mysAn.getDataAdapter
        rptAn.DataSource = mysAn.dataSet
        rptAn.DataMember = "anatomi"

        Dim rptE As New xrPenunjangE201801
        rptE.RequestParameters = False
        rptE.DataAdapter = mysE.getDataAdapter
        rptE.DataSource = mysE.dataSet
        rptE.DataMember = "ekg"

        Dim rptL As New xrPenunjangL201801
        rptL.RequestParameters = False
        rptL.DataAdapter = mysL.getDataAdapter
        rptL.DataSource = mysL.dataSet
        rptL.DataMember = "lab"

        Dim rptR As New xrPenunjangR201801
        rptR.RequestParameters = False
        rptR.DataAdapter = mysR.getDataAdapter
        rptR.DataSource = mysR.dataSet
        rptR.DataMember = "rad"

        Dim rptDPJP As New xrDPJPIGD201801
        rptDPJP.RequestParameters = False
        rptDPJP.DataAdapter = mysP.getDataAdapter
        rptDPJP.DataSource = mysP.dataSet
        rptDPJP.DataMember = "dpjp"

        Dim rptSOAP As New xrSOAPIncIGD201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.subEKG.ReportSource = rptE
        rptSOAP.subLAB.ReportSource = rptL
        rptSOAP.subRAD.ReportSource = rptR
        rptSOAP.subSkrg.ReportSource = rptS
        rptSOAP.subDulu.ReportSource = rptD
        rptSOAP.subObat.ReportSource = rptO
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIGD201801
        rpt.subAlergi.ReportSource = rptA
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.subDPJP.ReportSource = rptDPJP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmods"
        rpt.DisplayName = "AMODS201801"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pID").Visible = False
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pID").Visible = False
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
        If cetaktype = cu.cetak Then
            pt.Print()
        Else
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