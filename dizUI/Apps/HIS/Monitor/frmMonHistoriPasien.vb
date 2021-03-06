﻿Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonHistoriPasien
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idrm = -1
        'Me.WindowState = FormWindowState.Maximized
    End Sub

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

    Private idrm As String = -1
    Public Sub New(idpasien As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idrm = idpasien

        'Me.WindowState = FormWindowState.Normal
        'Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        'Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        'Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub frmMonHistoriPasien_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        If idrm = "-1" Then
            btnSearch.Visible = True
            lblKaryawan.Visible = True
            teSearch.Visible = True
            pMinimize.Visible = True
            pMaximize.Visible = True
        Else
            btnSearch.Visible = False
            lblKaryawan.Visible = False
            teSearch.Visible = False
            pMinimize.Visible = False
            pMaximize.Visible = False
        End If
        If idrm <> "-1" Then
            btnSemua_Click(btn10, Nothing)
        End If
        If Me.Location.X < 0 Then
            'Me.StartPosition = FormStartPosition.CenterParent
            'Dim pnt As Point = centerScreen(Me)
            ''Me.Location = New Point(pnt.X, pnt.Y)
            'Me.Left = pnt.X
            'Me.Top = pnt.Y
        End If
    End Sub

    Private Sub btnSemua_Click(sender As Object, e As EventArgs) Handles btn10.Click, btn25.Click, btn50.Click, btnSemua.Click
        btn10.BackColor = Color.FromArgb(192, 64, 0)
        btn25.BackColor = Color.FromArgb(0, 0, 64)
        btn50.BackColor = Color.FromArgb(192, 64, 0)
        btnSemua.BackColor = Color.FromArgb(0, 0, 64)

        CType(sender, Windows.Forms.Button).BackColor = Color.Gray
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {idrm})
        If sender Is btn10 Then
            sqls.CallSP("spHistoriPasien10", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 10 Register Terakhir"
        ElseIf sender Is btn25 Then
            sqls.CallSP("spHistoriPasien25", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 25 Register Terakhir"
        ElseIf sender Is btn50 Then
            sqls.CallSP("spHistoriPasien50", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - 50 Register Terakhir"
        ElseIf sender Is btnSemua Then
            sqls.CallSP("spHistoriPasienAll", "Histori", field, value)
            gvData.ViewCaption = "Riwayat Pasien - Semua Register"
        End If

        gcData.DataSource = sqls.dataTable("Histori")
        For i As Integer = 0 To gvData.RowCount - 1
            gvData.SetRowCellValue(i, GridColumn1, i + 1)
        Next
        gvData.BestFitColumns()
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

        Dim strQuery As String = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "SearchPasienLengkap.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim strfilter As String = ""
        strQuery &= " and r.rekammedisno<>0"
        If teSearch.Text <> "" Then
            strQuery &= " and (r.idrekammedis='" & teSearch.Text & "' or r.nama like '%" & teSearch.Text & "%' or replace(dbo.fformatnorm(r.rekammedisno),'-','') like '%" & teSearch.Text & "%' or dbo.fformatnorm(r.rekammedisno) like '%" & teSearch.Text & "%' or r.rekammedisno like '%" & teSearch.Text & "%') "
        End If
        strQuery &= " order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrm = cari.GetIDSelectData
            btnSemua_Click(btn10, Nothing)
        End If
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

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

    Private Sub ribeASM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles ribeASM.ButtonClick
        If gvData.FocusedRowHandle >= 0 Then
            Dim idreg As String = "0"
            Dim idasm As String = "0"
            Dim noform As String = "0"

            Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
            idreg = CStr(dr("idregistrasi"))
            idasm = CStr(dr("idassessment"))
            noform = CStr(dr("nomorform"))

            If idasm = "0" Then
                dizMsgbox("Belum dilakukan Assessment Medis", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            previewBerkasASM(idasm, idreg, noform, cu.preview)
        End If
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum

    Private Sub previewBerkasASM(iddata As String, idreg As String, nomorform As String, cetaktype As cu)
        If nomorform = "AMIGD201801" Then
            AMIGD201801(iddata, idreg, cetaktype)
        ElseIf nomorform = "AMIRJ201801" Then
            AMIRJ201801(iddata, idreg, cetaktype)
        ElseIf nomorform = "AMIRM201801" Then
            AMIRM201801(iddata, idreg, cetaktype)
        End If
    End Sub

    Private Sub AMIRM201801(iddata As String, idreg As String, cetaktype As cu)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIRM201801", "asmrhb", field, value)

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

        Dim rptSOAP As New xrSOAPIncRHB201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIRM201801
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmrhb"
        rpt.DisplayName = "AMIRM201901"
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
            Dim sharename As String = getPrinter("ASMIRM")
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
            'pt.Print()
        Else
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub AMIRJ201801(iddata As String, idreg As String, cetaktype As cu)
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
            'pt.Print()
        Else
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub AMIGD201801(iddata As String, idreg As String, cetaktype As cu)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIGD201801", "asmigd", field, value)

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
        rpt.DataMember = "asmigd"
        rpt.DisplayName = "AMIGD201801"
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

    Private idxFocus As Integer = -1
    Private Sub gvData_DoubleClick(sender As Object, e As EventArgs) Handles gvData.DoubleClick
        If gvData.RowCount = 0 Then Exit Sub

        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gvData
        idxFocus = view.FocusedRowHandle

        If idxFocus >= 0 Then
            Dim dr As DataRow = gvData.GetDataRow(idxFocus)
            Dim idreg As String = dr("idregistrasi")
            'Dim hl7 As New HL7SDK.Cda.

            If idreg <> "" Then
                Dim radsel10 As New frmSelectLabel10("")
                radsel10.bypass(idreg)
                radsel10.ShowDialog(Me)
            End If
        End If
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        idxFocus = e.FocusedRowHandle
    End Sub

End Class