Public Class frmExportMultiChart
    Private expType As String = ""
    Private expPath As String = ""
    Private ccgrafik As New List(Of DevExpress.XtraCharts.ChartControl)
    Public ReadOnly Property exportType() As String
        Get
            Return expType
        End Get
        'Set(ByVal exportType As String)
        '    expType = exportType
        'End Set
    End Property

    Public ReadOnly Property exportPath() As String
        Get
            Return expPath
        End Get
        'Set(ByVal exportPath As String)
        '    expPath = exportPath
        'End Set
    End Property

    Public WriteOnly Property gridControl() As List(Of DevExpress.XtraCharts.ChartControl)
        Set(ByVal chartcontrol As List(Of DevExpress.XtraCharts.ChartControl))
            ccgrafik = chartcontrol
        End Set
    End Property

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If expType = "" Then
            dizMsgbox("Pilih tipe export dulu", dizMsgboxStyle.Info, Me)
            Threading.Thread.Sleep(100)
            btnBrowse.Image = My.Resources.browse
            btnBrowse.BackColor = Color.Transparent
            btnBrowse.Refresh()
            Threading.Thread.Sleep(100)
            Exit Sub
        End If
        Dim dirbrowse As New FolderBrowserDialog
        dirbrowse.Description = "Pilih folder tempat menyimpan file hasil export"
        dirbrowse.RootFolder = Environment.SpecialFolder.MyComputer
        dirbrowse.ShowNewFolderButton = True
        If dirbrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
            expPath = dirbrowse.SelectedPath
            If expPath.Chars(expPath.Length - 1) = "\" Then expPath = expPath.Remove(expPath.Length - 1, 1)
            If expType = "JPG" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "PDF" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "XLS" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "XLSX" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "HTML" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "RTF" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            ElseIf expType = "MHT" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss")
            End If
        End If

        btnBrowse.BackColor = Color.Transparent
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        expPath = ""
        expType = ""
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If expPath = "" Then
            dizMsgbox("Folder belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If expType = "" Then
            dizMsgbox("Tipe Export belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        expPath = tboFilename.Text

        If IO.Directory.Exists(expPath) = False Then
            IO.Directory.CreateDirectory(expPath)
        End If
        If expType <> "" Then
            If expType = "JPG" Then
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".jpg"
                    ccgrafik(i).ExportToImage(filepath, Imaging.ImageFormat.Jpeg)
                Next
            ElseIf expType = "PDF" Then
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".pdf"
                    ccgrafik(i).ExportToPdf(filepath)
                Next
            ElseIf expType = "XLS" Then
                Dim xlsopt As New DevExpress.XtraPrinting.XlsExportOptions
                xlsopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                xlsopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                xlsopt.ShowGridLines = True
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".xls"
                    ccgrafik(i).ExportToXls(filepath, xlsopt)
                Next
            ElseIf expType = "XLSX" Then
                Dim xlsxopt As New DevExpress.XtraPrinting.XlsxExportOptions
                xlsxopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                xlsxopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                xlsxopt.ShowGridLines = True
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".xlsx"
                    ccgrafik(i).ExportToXlsx(filepath, xlsxopt)
                Next
            ElseIf expType = "HTML" Then
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".html"
                    ccgrafik(i).ExportToHtml(filepath)
                Next
            ElseIf expType = "RTF" Then
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".rtf"
                    ccgrafik(i).ExportToRtf(filepath)
                Next
            ElseIf expType = "MHT" Then
                For i As Integer = 0 To ccgrafik.Count - 1
                    Dim filepath As String = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & i & ".mht"
                    ccgrafik(i).ExportToMht(filepath)
                Next
            End If
            expPath = CheckAndRepairValidPath(expPath)
            If IO.Directory.Exists(expPath) Then
                Diagnostics.Process.Start(expPath)
            Else
                dizMsgbox("Folder tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            End If
        End If

        bClose = False
        Me.Dispose()
    End Sub

    'Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBrowse.MouseDown, pbExit.MouseDown, pbOK.MouseDown
    '    If sender.name = "pbExit" Then
    '        sender.backcolor = Color.FromArgb(255, 192, 192)
    '        sender.Image = My.Resources.exit_n
    '    ElseIf sender.name = "pbBrowse" Then
    '        sender.backcolor = Color.FromArgb(192, 255, 192)
    '        sender.Image = My.Resources.browse
    '    ElseIf sender.name = "pbOK" Then
    '        sender.backcolor = Color.FromArgb(192, 255, 192)
    '        sender.Image = My.Resources.ok
    '    End If
    'End Sub

    'Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBrowse.MouseEnter, pbExit.MouseEnter, pbOK.MouseEnter
    '    If sender.name = "pbExit" Then
    '        sender.backcolor = Color.Red 'FromArgb(255, 128, 128)
    '        sender.Image = My.Resources.exit_n
    '    ElseIf sender.name = "pbBrowse" Then
    '        sender.backcolor = Color.Lime 'FromArgb(128, 255, 128)
    '        sender.Image = My.Resources.browse
    '    ElseIf sender.name = "pbOK" Then
    '        sender.backcolor = Color.Lime 'FromArgb(128, 255, 128)
    '        sender.Image = My.Resources.ok
    '    End If
    'End Sub

    'Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbBrowse.MouseLeave, pbExit.MouseLeave, pbOK.MouseLeave
    '    If sender.name = "pbExit" Then
    '        sender.Image = My.Resources.exit_w
    '        sender.backcolor = Color.FromArgb(0, 143, 215)
    '        '0, 143, 215
    '    ElseIf sender.name = "pbBrowse" Then
    '        sender.Image = My.Resources.browse
    '        sender.backcolor = color.fromargb(240, 240, 240)
    '    ElseIf sender.name = "pbOK" Then
    '        sender.Image = My.Resources.ok
    '        sender.backcolor = color.fromargb(240, 240, 240)
    '    End If
    'End Sub

    'Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbBrowse.MouseUp, pbExit.MouseUp, pbOK.MouseUp
    '    If sender.name = "pbExit" Then
    '        sender.backcolor = Color.Red 'FromArgb(255, 128, 128)
    '        sender.Image = My.Resources.exit_n
    '    ElseIf sender.name = "pbBrowse" Then
    '        sender.backcolor = Color.Lime 'FromArgb(128, 255, 128)
    '        sender.Image = My.Resources.browse
    '    ElseIf sender.name = "pbOK" Then
    '        sender.backcolor = Color.Lime 'FromArgb(128, 255, 128)
    '        sender.Image = My.Resources.ok
    '    End If
    'End Sub

    Private Sub btnTXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJPG.Click, btnPDF.Click, btnXLS.Click, btnXLSX.Click, btnHTML.Click, btnRTF.Click, btnMHT.Click
        If expPath <> "" Then expPath = ""
        tboFilename.Text = expPath

        expType = sender.tag
        If sender.name = "btnJPG" Then
            btnJPG.BackColor = Color.Olive
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPDF" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.Olive
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLS" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.Olive
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLSX" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.Olive
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnHTML" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.Olive
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnRTF" Then
            btnJPG.BackColor = Color.Olive
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.Olive
            btnMHT.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnMHT" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
            btnMHT.BackColor = Color.Olive
        End If
    End Sub

    Private bClose As Boolean = True
    Private Sub frmExport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        expPath = ""
        expType = ""
        btnExit.BackColor = Color.Transparent
        btnOK.BackColor = Color.Transparent
        btnBrowse.BackColor = Color.Transparent

        Dim cekbool As Boolean = True
        For i As Integer = 0 To ccgrafik.Count - 1
            If ccgrafik(i).Series.Count = 0 Then
                cekbool = False
                Exit For
            End If
        Next
        If cekbool = False Then
            dizMsgbox("Data tidak ditemukan, silahkan set chartcontrol terlebih dahulu", dizMsgboxStyle.Peringatan, Me)
            btnExit_Click(Me, Nothing)
        End If
    End Sub

    Public Sub New(ByVal chartcontrol As List(Of DevExpress.XtraCharts.ChartControl))
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ccgrafik = chartcontrol
    End Sub

End Class