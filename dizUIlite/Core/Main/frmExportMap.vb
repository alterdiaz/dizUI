Public Class frmExportMap
    Private expType As String = ""
    Private expPath As String = ""
    Private mcpeta As New DevExpress.XtraMap.MapControl
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

    Public WriteOnly Property gridControl() As DevExpress.XtraMap.MapControl
        Set(ByVal mc As DevExpress.XtraMap.MapControl)
            mcpeta = mc
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

        If expType <> "" Then
            If expType = "JPG" Then
                mcpeta.ExportToImage(expPath, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf expType = "DOCX" Then
                mcpeta.ExportToDocx(expPath)
            ElseIf expType = "PDF" Then
                mcpeta.ExportToPdf(expPath)
            ElseIf expType = "XLS" Then
                mcpeta.ExportToXls(expPath)
            ElseIf expType = "XLSX" Then
                mcpeta.ExportToXlsx(expPath)
            ElseIf expType = "RTF" Then
                mcpeta.ExportToRtf(expPath)
            End If
        End If
        If IO.File.Exists(expPath) Then
            Diagnostics.Process.Start(expPath)
        Else
            dizMsgbox("File not found", dizMsgboxStyle.Kesalahan, Me)
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

    Private Sub btnTXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJPG.Click, btnDOCX.Click, btnPDF.Click, btnXLS.Click, btnXLSX.Click, btnRTF.Click
        If expPath <> "" Then expPath = ""
        tboFilename.Text = expPath

        expType = sender.tag
        If sender.name = "btnJPG" Then
            btnJPG.BackColor = Color.Olive
            btnDOCX.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnDOCX" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnDOCX.BackColor = Color.Olive
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPDF" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnDOCX.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.Olive
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLS" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnDOCX.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.Olive
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnXLSX" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnDOCX.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.Olive
            btnRTF.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnRTF" Then
            btnJPG.BackColor = Color.FromArgb(64, 0, 64)
            btnDOCX.BackColor = Color.FromArgb(64, 0, 64)
            btnPDF.BackColor = Color.FromArgb(64, 0, 64)
            btnXLS.BackColor = Color.FromArgb(64, 0, 64)
            btnXLSX.BackColor = Color.FromArgb(64, 0, 64)
            btnRTF.BackColor = Color.Olive
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

        If mcpeta.Layers.Count = 1 Then
            dizMsgbox("Data tidak ditemukan, silahkan set datagridview terlebih dahulu", dizMsgboxStyle.Peringatan, Me)
            btnExit_Click(Me, Nothing)
        End If
    End Sub

    Public Sub New(ByVal mcpeta As DevExpress.XtraMap.MapControl)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mcpeta = mcpeta
    End Sub

End Class