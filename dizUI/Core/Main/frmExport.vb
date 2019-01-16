Public Class frmExport
    Private expType As String = ""
    Private expPath As String = ""
    Private gvdata As New DevExpress.XtraGrid.Views.Grid.GridView
    Private gcdata As New DevExpress.XtraGrid.GridControl
    Private dataType As String = ""
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

    Public WriteOnly Property gridView() As DevExpress.XtraGrid.Views.Grid.GridView
        Set(ByVal datagridview As DevExpress.XtraGrid.Views.Grid.GridView)
            gvdata = datagridview
        End Set
    End Property

    Public WriteOnly Property gridControl() As DevExpress.XtraGrid.GridControl
        Set(ByVal datagridcontrol As DevExpress.XtraGrid.GridControl)
            gcdata = datagridcontrol
        End Set
    End Property

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If expType = "" Then
            dizMsgbox("Pilih tipe export dulu", dizMsgboxStyle.Info, Me)
            Threading.Thread.Sleep(1000)
            btnBrowse.Image = My.Resources.browse
            btnBrowse.BackColor = Color.Transparent
            btnBrowse.Refresh()
            Threading.Thread.Sleep(1000)
            Exit Sub
        End If
        Dim dirbrowse As New FolderBrowserDialog
        dirbrowse.Description = "Pilih folder tempat menyimpan file hasil export"
        dirbrowse.RootFolder = Environment.SpecialFolder.MyComputer
        dirbrowse.ShowNewFolderButton = True
        If dirbrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
            expPath = dirbrowse.SelectedPath
            If expPath.Chars(expPath.Length - 1) = "\" Then expPath = expPath.Remove(expPath.Length - 1, 1)
            If expType = "TXT" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & ".txt"
            ElseIf expType = "HTML" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & ".html"
            ElseIf expType = "PDF" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & ".pdf"
            ElseIf expType = "XLS" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & ".xls"
            ElseIf expType = "XLSX" Then
                tboFilename.Text = expPath & "\ExportResult" & Format(nowTime, "yyyyMMdd-HHmmss") & ".xlsx"
            End If
        End If

        btnBrowse.BackColor = Color.Transparent
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        expPath = ""
        expType = ""
        dataType = ""
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If expPath = "" Then
            dizmsgbox("Folder belum dipilih", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        If expType = "" Then
            dizmsgbox("Tipe Export belum dipilih", dizMsgboxStyle.peringatan, Me)
            Exit Sub
        End If
        expPath = tboFilename.Text

        If expType <> "" Then
            If dataType = "View" Then
                If expType = "TXT" Then
                    gvdata.ExportToText(expPath)
                ElseIf expType = "HTML" Then
                    gvdata.ExportToHtml(expPath)
                ElseIf expType = "PDF" Then
                    gvdata.ExportToPdf(expPath)
                ElseIf expType = "XLS" Then
                    Dim xlsopt As New DevExpress.XtraPrinting.XlsExportOptionsEx
                    xlsopt.ExportType = DevExpress.Export.ExportType.WYSIWYG
                    xlsopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    xlsopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    xlsopt.ShowGridLines = True

                    'Dim xlsopt As New DevExpress.XtraPrinting.XlsExportOptions
                    'xlsopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    'xlsopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    'xlsopt.ShowGridLines = True
                    gvdata.ExportToXls(expPath, xlsopt)
                ElseIf expType = "XLSX" Then
                    Dim xlsxopt As DevExpress.XtraPrinting.XlsxExportOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx()
                    xlsxopt.ExportType = DevExpress.Export.ExportType.WYSIWYG
                    xlsxopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    xlsxopt.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile
                    xlsxopt.ShowGridLines = True

                    'Dim xlsxopt As New DevExpress.XtraPrinting.XlsxExportOptions
                    'xlsxopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    'xlsxopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    'xlsxopt.ShowGridLines = True
                    gvdata.ExportToXlsx(expPath, xlsxopt)
                End If
            ElseIf dataType = "Grid" Then
                If expType = "TXT" Then
                    gcdata.ExportToText(expPath)
                ElseIf expType = "HTML" Then
                    gcdata.ExportToHtml(expPath)
                ElseIf expType = "PDF" Then
                    'Dim pdfopt As New DevExpress.XtraPrinting.PdfExportOptions
                    'pdfopt.Compressed = False
                    'pdfopt.ConvertImagesToJpeg = True
                    'pdfopt.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                    gcdata.ExportToPdf(expPath)
                ElseIf expType = "XLS" Then
                    Dim xlsopt As New DevExpress.XtraPrinting.XlsExportOptionsEx
                    xlsopt.ExportType = DevExpress.Export.ExportType.WYSIWYG
                    xlsopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    xlsopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    xlsopt.ShowGridLines = True

                    'Dim xlsopt As New DevExpress.XtraPrinting.XlsExportOptions
                    'xlsopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    'xlsopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    'xlsopt.ShowGridLines = True
                    gcdata.ExportToXls(expPath, xlsopt)
                ElseIf expType = "XLSX" Then
                    Dim xlsxopt As DevExpress.XtraPrinting.XlsxExportOptionsEx = New DevExpress.XtraPrinting.XlsxExportOptionsEx()
                    xlsxopt.ExportType = DevExpress.Export.ExportType.WYSIWYG
                    xlsxopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    xlsxopt.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile
                    xlsxopt.ShowGridLines = True

                    'Dim xlsxopt As New DevExpress.XtraPrinting.XlsxExportOptions
                    'xlsxopt.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text
                    'xlsxopt.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile
                    'xlsxopt.ShowGridLines = True
                    gcdata.ExportToXlsx(expPath, xlsxopt)
                End If
            End If
            If IO.File.Exists(expPath) Then
                Diagnostics.Process.Start(expPath)
            Else
                dizMsgbox("File not found", dizMsgboxStyle.Kesalahan, Me)
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

    Private Sub btnTXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTXT.Click, btnHTML.Click, btnPDF.Click, btnXLS.Click, btnXLSX.Click
        If expPath <> "" Then expPath = ""
        tboFilename.Text = expPath

        expType = sender.tag
        If sender.name = "btnTXT" Then
            btnTXT.BackColor = Color.Olive
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnHTML" Then
            btnTXT.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.Olive
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPDF" Then
            btnTXT.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.Olive
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLS" Then
            btnTXT.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.Olive
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLSX" Then
            btnTXT.BackColor = Color.FromArgb(64, 0, 64)
            btnHTML.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.Olive
        End If
    End Sub

    Private bClose As Boolean = True
    Private Sub frmExport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private Sub frmExport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        expPath = ""
        expType = ""
        btnExit.BackColor = Color.Transparent
        btnOK.BackColor = Color.Transparent
        btnBrowse.BackColor = Color.Transparent

        If dataType = "View" Then
            If gvdata.DataRowCount = 0 Then
                dizmsgbox("Data tidak ditemukan, silahkan set datagridview terlebih dahulu", dizMsgboxStyle.peringatan, Me)
                btnExit_Click(Me, Nothing)
            End If
        End If
    End Sub

    Public Sub New(ByVal datagridview As DevExpress.XtraGrid.Views.Grid.GridView)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gvdata = DataGridView
        dataType = "View"
    End Sub

    Public Sub New(ByVal datagridcontrol As DevExpress.XtraGrid.GridControl)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gcdata = datagridcontrol
        dataType = "Grid"
    End Sub

End Class