Imports DevExpress.XtraGrid.Views.Base
Public Class frmBoardPelayananPeriode
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

        deTanggal1.EditValue = Nothing
        deTanggal2.EditValue = Nothing
        'deTanggal.EditValue = nowTime
        Threading.Thread.Sleep(100)
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub deTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggal1.EditValueChanged, deTanggal2.EditValueChanged
        If deTanggal1.EditValue Is Nothing Then
            Exit Sub
        End If
        If deTanggal2.EditValue Is Nothing Then
            Exit Sub
        End If
        If CDate(deTanggal1.EditValue) > CDate(deTanggal2.EditValue) Then
            dizMsgbox("Periode Tahun 1 tidak boleh lebih besar dari Periode Tahun 2", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        loadRegisterHarian(Format(CDate(deTanggal1.EditValue), "yyyy"), Format(CDate(deTanggal2.EditValue), "yyyy"))
        loadRegisterIGD(Format(CDate(deTanggal1.EditValue), "yyyy"), Format(CDate(deTanggal2.EditValue), "yyyy"))
        loadRegisterDept(Format(CDate(deTanggal1.EditValue), "yyyy"), Format(CDate(deTanggal2.EditValue), "yyyy"))

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal1, Nothing)
    End Sub

    Private Sub loadRegisterDept(param As String, param2 As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode1", "@periode2"})
        value.AddRange(New String() {param, param2})
        sqls.CallSP("spPeriodeRegistrasi", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegDept.Series.Clear()
        ccRegDept.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series(param, DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series(param2, DevExpress.XtraCharts.ViewType.Bar)

        Dim legend As New DevExpress.XtraCharts.Legend("legend")
        legend.Visibility = DevExpress.Utils.DefaultBoolean.True
        legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
        legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
        legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
        legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        legend.MaxVerticalPercentage = 100
        legend.MaxHorizontalPercentage = 100
        legend.TextVisible = True

        series1.LegendTextPattern = series1.Name
        series1.LegendText = series1.Name
        series1.ShowInLegend = True
        series1.Legend = legend

        series2.LegendTextPattern = series2.Name
        series2.LegendText = series2.Name
        series2.ShowInLegend = True
        series2.Legend = legend

        ccRegDept.Series.Add(series1)
        ccRegDept.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccRegDept.DataSource = sqls.dataTable("reg")
        ccRegDept.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"total1"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"total2"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccRegDept.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Registrasi Dept - " & CDate(deTanggal1.EditValue).Year & " " & CDate(deTanggal2.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegDept.Titles.Clear()
        ccRegDept.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegDept.Dock = DockStyle.Fill
    End Sub


    Private Sub loadRegisterIGD(param As String, param2 As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode", "@periode2"})
        value.AddRange(New String() {param, param2})
        sqls.CallSP("spPeriodeRegIGD", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegIGD.Series.Clear()
        ccRegIGD.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Reguler " & param, DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Elektif " & param, DevExpress.XtraCharts.ViewType.Bar)
        Dim series3 As New DevExpress.XtraCharts.Series("Reguler " & param2, DevExpress.XtraCharts.ViewType.Bar)
        Dim series4 As New DevExpress.XtraCharts.Series("Elektif " & param2, DevExpress.XtraCharts.ViewType.Bar)

        Dim legend As New DevExpress.XtraCharts.Legend("legend")
        legend.Visibility = DevExpress.Utils.DefaultBoolean.True
        legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
        legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
        legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
        legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        legend.MaxVerticalPercentage = 100
        legend.MaxHorizontalPercentage = 100
        legend.TextVisible = True

        series1.LegendTextPattern = series1.Name
        series1.LegendText = series1.Name
        series1.ShowInLegend = True
        series1.Legend = legend
        series2.LegendTextPattern = series2.Name
        series2.LegendText = series2.Name
        series2.ShowInLegend = True
        series2.Legend = legend
        series3.LegendTextPattern = series3.Name
        series3.LegendText = series3.Name
        series3.ShowInLegend = True
        series3.Legend = legend
        series4.LegendTextPattern = series4.Name
        series4.LegendText = series4.Name
        series4.ShowInLegend = True
        series4.Legend = legend

        ccRegIGD.Series.Add(series1)
        ccRegIGD.Series.Add(series2)
        ccRegIGD.Series.Add(series3)
        ccRegIGD.Series.Add(series4)
        ' Generate a data table and bind the series to it.
        ccRegIGD.DataSource = sqls.dataTable("reg")
        ccRegIGD.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "periode"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter1"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "periode"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"counterelektif1"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series3.ArgumentDataMember = "periode"
        series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series3.ValueDataMembers.AddRange(New String() {"counter2"})
        series3.Label.TextAlignment = StringAlignment.Far
        series3.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series3.Label.EnableAntialiasing = True
        series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series4.ArgumentDataMember = "periode"
        series4.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series4.ValueDataMembers.AddRange(New String() {"counterelektif2"})
        series4.Label.TextAlignment = StringAlignment.Far
        series4.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series4.Label.EnableAntialiasing = True
        series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series3.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series4.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series3.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series4.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Periode"
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Registrasi IGD - " & CDate(deTanggal1.EditValue).Year & " " & CDate(deTanggal2.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegIGD.Titles.Clear()
        ccRegIGD.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegIGD.Dock = DockStyle.Fill
    End Sub

    Private Sub loadRegisterHarian(param As String, param2 As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode1", "@periode2"})
        value.AddRange(New String() {param, param2})
        sqls.CallSP("spPeriodeReg", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegHarian.Series.Clear()
        ccRegHarian.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series(param, DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series(param2, DevExpress.XtraCharts.ViewType.Bar)

        Dim legend As New DevExpress.XtraCharts.Legend("legend")
        legend.Visibility = DevExpress.Utils.DefaultBoolean.True
        legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
        legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
        legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
        legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        legend.MaxVerticalPercentage = 100
        legend.MaxHorizontalPercentage = 100
        legend.TextVisible = True

        'series1.LegendTextPattern = series1.Name
        'series1.LegendText = series1.Name
        'series1.ShowInLegend = True
        'series1.Legend = legend

        series1.LegendTextPattern = series1.Name
        series1.LegendText = series1.Name
        series1.ShowInLegend = True
        series1.Legend = legend

        series2.LegendTextPattern = series2.Name
        series2.LegendText = series2.Name
        series2.ShowInLegend = True
        series2.Legend = legend

        ccRegHarian.Series.Add(series1)
        ccRegHarian.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccRegHarian.DataSource = sqls.dataTable("reg")
        ccRegHarian.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto

        series1.ArgumentDataMember = "periode"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter1"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.ResolveOverlappingMinIndent = 0
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "periode"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"counter2"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.MinorCount = 1
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Periode"
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.MinIndent = 0
        CType(ccRegHarian.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Registrasi Bulanan - " & CDate(deTanggal1.EditValue).Year & " " & CDate(deTanggal2.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegHarian.Titles.Clear()
        ccRegHarian.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegHarian.Dock = DockStyle.Fill
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If ccRegHarian.Series.Count > 0 Then
            Dim mc As New List(Of DevExpress.XtraCharts.ChartControl)

            mc.Add(ccRegHarian)
            mc.Add(ccRegIGD)
            mc.Add(ccRegDept)

            Dim exp As New frmExportMultiChart(mc)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
        'TakeScreenShot(tlpGrafik).Save("D:\Screenshot.png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    'Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
    '    Dim tmpImg As New Bitmap(Control.Width, Control.Height)
    '    Using g As Graphics = Graphics.FromImage(tmpImg)
    '        g.CopyFromScreen(tlpGrafik.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(tlpGrafik.Width, tlpGrafik.Height))
    '    End Using
    '    Return tmpImg
    'End Function

End Class