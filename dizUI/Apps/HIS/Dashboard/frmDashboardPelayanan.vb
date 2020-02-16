Imports DevExpress.XtraGrid.Views.Base
Public Class frmDashboardPelayanan
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

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.EditValue = Nothing
        'deTanggal.EditValue = nowTime
        Threading.Thread.Sleep(100)
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal.EditValueChanged
        If deTanggal.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        loadRegisterHarian(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadRegisterIGD(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadAPSrad(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadAPSlab(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadODS(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadICD(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadParamedis(Format(CDate(deTanggal.EditValue), "MM-yyyy"))

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub loadRegisterHarian(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusRegHarian", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegHarian.Series.Clear()
        ccRegHarian.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Registrasi", DevExpress.XtraCharts.ViewType.Bar)

        'series1.LegendTextPattern = series1.Name
        'series1.LegendText = series1.Name
        'series1.ShowInLegend = True
        'series1.Legend = legend

        ccRegHarian.Series.Add(series1)
        ' Generate a data table and bind the series to it.
        ccRegHarian.DataSource = sqls.dataTable("reg")
        'ccRegHarian.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "tanggal"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.ResolveOverlappingMinIndent = 0
        series1.Label.EnableAntialiasing = True
        series1.ShowInLegend = False
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.NumericScaleOptions.AutoGrid = False
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.NumericScaleOptions.GridSpacing = 1
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.MinorCount = 1
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Tanggal"
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.MinIndent = 0
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Registrasi Harian"
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegHarian.Titles.Clear()
        ccRegHarian.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegHarian.Dock = DockStyle.Fill
    End Sub

    Private Sub loadRegisterIGD(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusIGD", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegIGD.Series.Clear()
        ccRegIGD.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Pie)

        series1.ShowInLegend = False
        series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "regstatus"
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextPattern = "{A}: {VP:p0}"
        series1.Label.TextAlignment = StringAlignment.Near
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True

        ccRegIGD.Series.Add(series1)
        ccRegIGD.DataSource = sqls.dataTable("reg")

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.PieSeriesLabel).Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        CType(series1.View, DevExpress.XtraCharts.PieSeriesView).HeightToWidthRatio = 1

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Status IGD"
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegIGD.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        ccRegIGD.Titles.Clear()
        ccRegIGD.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegIGD.Dock = DockStyle.Fill
    End Sub

    Private Sub loadAPSlab(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusAPSlab", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegLAB.Series.Clear()
        ccRegLAB.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Pie)

        series1.ShowInLegend = False
        series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "regstatus"
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextPattern = "{A}: {VP:p0}"
        series1.Label.TextAlignment = StringAlignment.Near
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True

        ccRegLAB.Series.Add(series1)
        ccRegLAB.DataSource = sqls.dataTable("reg")

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.PieSeriesLabel).Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        CType(series1.View, DevExpress.XtraCharts.PieSeriesView).HeightToWidthRatio = 1

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Status LAB"
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegLAB.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        ccRegLAB.Titles.Clear()
        ccRegLAB.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegLAB.Dock = DockStyle.Fill
    End Sub

    Private Sub loadAPSrad(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusAPSrad", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegRAD.Series.Clear()
        ccRegRAD.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Pie)

        series1.ShowInLegend = False
        series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "regstatus"
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextPattern = "{A}: {VP:p0}"
        series1.Label.TextAlignment = StringAlignment.Near
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True

        ccRegRAD.Series.Add(series1)
        ccRegRAD.DataSource = sqls.dataTable("reg")

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.PieSeriesLabel).Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        CType(series1.View, DevExpress.XtraCharts.PieSeriesView).HeightToWidthRatio = 1

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Status RAD"
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegRAD.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        ccRegRAD.Titles.Clear()
        ccRegRAD.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegRAD.Dock = DockStyle.Fill
    End Sub

    Private Sub loadODS(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusODS", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegODS.Series.Clear()
        ccRegODS.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Pie)

        series1.ShowInLegend = False
        series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "regstatus"
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextPattern = "{A}: {VP:p0}"
        series1.Label.TextAlignment = StringAlignment.Near
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True

        ccRegODS.Series.Add(series1)
        ccRegODS.DataSource = sqls.dataTable("reg")

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.PieSeriesLabel).Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside
        CType(series1.View, DevExpress.XtraCharts.PieSeriesView).HeightToWidthRatio = 1

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Asal ODS"
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegODS.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        ccRegODS.Titles.Clear()
        ccRegODS.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegODS.Dock = DockStyle.Fill
    End Sub

    Private Sub loadICD(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusICD", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccICD.Series.Clear()
        ccICD.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Bar)

        'series1.LegendTextPattern = series1.Name
        'series1.LegendText = series1.Name
        'series1.ShowInLegend = True
        'series1.Legend = legend

        ccICD.Series.Add(series1)
        ' Generate a data table and bind the series to it.
        ccICD.DataSource = sqls.dataTable("reg")
        'ccicd.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "kode"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.ResolveOverlappingMinIndent = 0
        series1.Label.EnableAntialiasing = True
        series1.ShowInLegend = False
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = True

        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.MinorCount = 1
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "ICD"
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.MinIndent = 0
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False
        CType(ccICD.Diagram, DevExpress.XtraCharts.XYDiagram).Rotated = True

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Top 5 ICD"
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccICD.Titles.Clear()
        ccICD.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccICD.Dock = DockStyle.Fill
    End Sub

    Private Sub loadParamedis(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusParamedis", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccParamedis.Series.Clear()
        ccParamedis.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Series", DevExpress.XtraCharts.ViewType.Bar)

        'series1.LegendTextPattern = series1.Name
        'series1.LegendText = series1.Name
        'series1.ShowInLegend = True
        'series1.Legend = legend

        ccParamedis.Series.Add(series1)
        ' Generate a data table and bind the series to it.
        ccParamedis.DataSource = sqls.dataTable("reg")
        'ccparamedis.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "paramedis"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.ResolveOverlappingMinIndent = 0
        series1.Label.EnableAntialiasing = True
        series1.ShowInLegend = False
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = True

        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.MinorCount = 1
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 8.0!)
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Paramedis"
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.MinIndent = 0
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False
        CType(ccParamedis.Diagram, DevExpress.XtraCharts.XYDiagram).Rotated = True

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 8.0!)
        ct.Text = "Top 5 Paramedis"
        ct.Alignment = StringAlignment.Near
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccParamedis.Titles.Clear()
        ccParamedis.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccParamedis.Dock = DockStyle.Fill
    End Sub

End Class