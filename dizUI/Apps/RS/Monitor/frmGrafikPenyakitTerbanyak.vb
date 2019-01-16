Public Class frmGrafikPenyakitTerbanyak
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

    Private Sub deTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTanggal.EditValueChanged
        Dim iscek As Boolean = False
        If deTanggal.EditValue Is Nothing Then
            iscek = True
        End If
        If iscek = True Then
            ccGrafik.DataSource = Nothing
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@tahun", "@bulan"})
        value.AddRange(New Object() {CDate(deTanggal.EditValue).Year, CDate(deTanggal.EditValue).Month})
        sqls.CallSP("sp10PenyakitTerbanyak", "monpenyakitterbanyak", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccGrafik.Series.Clear()
        Dim series As New DevExpress.XtraCharts.Series("Series1", DevExpress.XtraCharts.ViewType.Bar)
        ccGrafik.Series.Add(series)
        ' Generate a data table and bind the series to it.
        ccGrafik.DataSource = sqls.dataTable("monpenyakitterbanyak")

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series.ArgumentDataMember = "kode"
        series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series.ValueDataMembers.AddRange(New String() {"counter"})

        series.Label.TextAlignment = StringAlignment.Far
        series.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series.Label.EnableAntialiasing = True
        series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = True
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True

        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Kode ICD-X"
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccGrafik.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        ccGrafik.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Penyakit Terbanyak - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccGrafik.Titles.Clear()
        ccGrafik.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccGrafik.Dock = DockStyle.Fill
        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
        ccGrafik.Titles.Clear()
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If ccGrafik.Series.Count > 0 Then
            Dim exp As New frmExportChart(ccGrafik)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

End Class