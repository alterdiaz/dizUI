Imports DevExpress.XtraGrid.Views.Base
Public Class frmBoardPelayanan
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
        loadRegisterDept(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadRegister(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadAPS(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadRM(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadASM(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadPenyakit(Format(CDate(deTanggal.EditValue), "MM-yyyy"))
        loadBL(Format(CDate(deTanggal.EditValue), "MM-yyyy"))

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggal_EditValueChanged(deTanggal, Nothing)
    End Sub

    Private Sub loadRegisterDept(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusRegistrasi", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegDept.Series.Clear()
        ccRegDept.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Total Reg", DevExpress.XtraCharts.ViewType.Bar)

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

        ccRegDept.Series.Add(series1)
        ' Generate a data table and bind the series to it.
        ccRegDept.DataSource = sqls.dataTable("reg")
        ccRegDept.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"total"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

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
        ct.Text = "Registrasi Dept - " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegDept.Titles.Clear()
        ccRegDept.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegDept.Dock = DockStyle.Fill
    End Sub

    Private Sub loadRegister(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusRegistrasi", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegister.Series.Clear()
        ccRegister.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Terbuka", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Batal", DevExpress.XtraCharts.ViewType.Bar)
        Dim series3 As New DevExpress.XtraCharts.Series("Rujuk", DevExpress.XtraCharts.ViewType.Bar)
        Dim series4 As New DevExpress.XtraCharts.Series("KRS APS", DevExpress.XtraCharts.ViewType.Bar)
        Dim series5 As New DevExpress.XtraCharts.Series("Kabur", DevExpress.XtraCharts.ViewType.Bar)
        Dim series6 As New DevExpress.XtraCharts.Series("Meninggal", DevExpress.XtraCharts.ViewType.Bar)
        Dim series7 As New DevExpress.XtraCharts.Series("KRS/Closing", DevExpress.XtraCharts.ViewType.Bar)
        Dim series8 As New DevExpress.XtraCharts.Series("MRS", DevExpress.XtraCharts.ViewType.Bar)

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
        series5.LegendTextPattern = series5.Name
        series5.LegendText = series5.Name
        series5.ShowInLegend = True
        series5.Legend = legend
        series6.LegendTextPattern = series6.Name
        series6.LegendText = series6.Name
        series6.ShowInLegend = True
        series6.Legend = legend
        series7.LegendTextPattern = series7.Name
        series7.LegendText = series7.Name
        series7.ShowInLegend = True
        series7.Legend = legend
        series8.LegendTextPattern = series8.Name
        series8.LegendText = series8.Name
        series8.ShowInLegend = True
        series8.Legend = legend

        ccRegister.Series.Add(series1)
        ccRegister.Series.Add(series2)
        ccRegister.Series.Add(series3)
        ccRegister.Series.Add(series4)
        ccRegister.Series.Add(series5)
        ccRegister.Series.Add(series6)
        ccRegister.Series.Add(series7)
        ccRegister.Series.Add(series8)
        ' Generate a data table and bind the series to it.
        ccRegister.DataSource = sqls.dataTable("reg")
        ccRegister.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"terbuka"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"batal"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series3.ArgumentDataMember = "department"
        series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series3.ValueDataMembers.AddRange(New String() {"dirujuk"})
        series3.Label.TextAlignment = StringAlignment.Far
        series3.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series3.Label.EnableAntialiasing = True
        series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series4.ArgumentDataMember = "department"
        series4.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series4.ValueDataMembers.AddRange(New String() {"paksa"})
        series4.Label.TextAlignment = StringAlignment.Far
        series4.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series4.Label.EnableAntialiasing = True
        series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series5.ArgumentDataMember = "department"
        series5.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series5.ValueDataMembers.AddRange(New String() {"kabur"})
        series5.Label.TextAlignment = StringAlignment.Far
        series5.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series5.Label.EnableAntialiasing = True
        series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series6.ArgumentDataMember = "department"
        series6.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series6.ValueDataMembers.AddRange(New String() {"meninggal"})
        series6.Label.TextAlignment = StringAlignment.Far
        series6.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series6.Label.EnableAntialiasing = True
        series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series7.ArgumentDataMember = "department"
        series7.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series7.ValueDataMembers.AddRange(New String() {"tutup"})
        series7.Label.TextAlignment = StringAlignment.Far
        series7.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series7.Label.EnableAntialiasing = True
        series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series8.ArgumentDataMember = "department"
        series8.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series8.ValueDataMembers.AddRange(New String() {"mrs"})
        series8.Label.TextAlignment = StringAlignment.Far
        series8.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series8.Label.EnableAntialiasing = True
        series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series3.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series4.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series5.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series6.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series7.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series8.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series3.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series4.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series5.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series6.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series7.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series8.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowRotate = True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowStagger = True
        CType(ccRegister.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Status Registrasi - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegister.Titles.Clear()
        ccRegister.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegister.Dock = DockStyle.Fill
    End Sub

    Private Sub loadRegisterIGD(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusRegIGD", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccRegIGD.Series.Clear()
        ccRegIGD.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Reguler", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Elektif", DevExpress.XtraCharts.ViewType.Bar)

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

        ccRegIGD.Series.Add(series1)
        ccRegIGD.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccRegIGD.DataSource = sqls.dataTable("reg")
        ccRegIGD.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "tanggal"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"counter"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "tanggal"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"counterelektif"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

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
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Tanggal"
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccRegIGD.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Registrasi IGD - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegIGD.Titles.Clear()
        ccRegIGD.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegIGD.Dock = DockStyle.Fill
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
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

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
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Registrasi Harian - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccRegHarian.Titles.Clear()
        ccRegHarian.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccRegHarian.Dock = DockStyle.Fill
    End Sub

    Private Sub loadAPS(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusAPS", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccAPS.Series.Clear()
        ccAPS.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("APS", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Non APS", DevExpress.XtraCharts.ViewType.Bar)

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

        ccAPS.Series.Add(series1)
        ccAPS.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccAPS.DataSource = sqls.dataTable("reg")
        ccAPS.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"aps"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"nonaps"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccAPS.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Pasien APS - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccAPS.Titles.Clear()
        ccAPS.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccAPS.Dock = DockStyle.Fill
    End Sub

    Private Sub loadRM(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusResponTime", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccTimeResponRM.Series.Clear()
        ccTimeResponRM.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Respon RM", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Respon Unit", DevExpress.XtraCharts.ViewType.Bar)

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

        ccTimeResponRM.Series.Add(series1)
        ccTimeResponRM.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccTimeResponRM.DataSource = sqls.dataTable("reg")
        ccTimeResponRM.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"preptime"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"recvtime"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Respon Time"
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccTimeResponRM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Respon Time Berkas RM - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccTimeResponRM.Titles.Clear()
        ccTimeResponRM.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccTimeResponRM.Dock = DockStyle.Fill
    End Sub

    Private Sub loadASM(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusASM", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccASM.Series.Clear()
        ccASM.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Belum ASM", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Telah ASM", DevExpress.XtraCharts.ViewType.Bar)

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

        ccASM.Series.Add(series1)
        ccASM.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccASM.DataSource = sqls.dataTable("reg")
        ccASM.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"belumasm"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"sudahasm"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccASM.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Assessment Medis - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccASM.Titles.Clear()
        ccASM.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccASM.Dock = DockStyle.Fill
    End Sub

    Private Sub loadPenyakit(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusPenyakitTerbanyak", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccPenyakit.Series.Clear()
        ccPenyakit.Legends.Clear()
        Dim series As New DevExpress.XtraCharts.Series("ICD-X", DevExpress.XtraCharts.ViewType.Bar)

        'Dim legend As New DevExpress.XtraCharts.Legend("legend")
        'legend.Visibility = DevExpress.Utils.DefaultBoolean.True
        'legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
        'legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
        'legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
        'legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        'legend.MaxVerticalPercentage = 100
        'legend.MaxHorizontalPercentage = 100
        'legend.TextVisible = True

        'series.LegendTextPattern = series.Name
        'series.LegendText = series.Name
        'series.ShowInLegend = True
        'series.Legend = legend

        ccPenyakit.Series.Add(series)
        ' Generate a data table and bind the series to it.
        ccPenyakit.DataSource = sqls.dataTable("reg")
        'ccPenyakit.Legends.Add(legend)

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
        CType(series.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True

        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.MinorCount = 1
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "ICD-X"
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccPenyakit.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Penyakit Terbanyak - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccPenyakit.Titles.Clear()
        ccPenyakit.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccPenyakit.Dock = DockStyle.Fill
    End Sub

    Private Sub loadBL(param As String)
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@periode"})
        value.AddRange(New String() {param})
        sqls.CallSP("spStatusBaruLama", "reg", field, value)

        ' Create an empty Bar series and add it to the chart.
        ccPxLB.Series.Clear()
        ccPxLB.Legends.Clear()
        Dim series1 As New DevExpress.XtraCharts.Series("Pasien Baru", DevExpress.XtraCharts.ViewType.Bar)
        Dim series2 As New DevExpress.XtraCharts.Series("Pasien Lama", DevExpress.XtraCharts.ViewType.Bar)

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

        ccPxLB.Series.Add(series1)
        ccPxLB.Series.Add(series2)
        ' Generate a data table and bind the series to it.
        ccPxLB.DataSource = sqls.dataTable("reg")
        ccPxLB.Legends.Add(legend)

        ' Specify data members to bind the series.
        'series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Auto
        series1.ArgumentDataMember = "department"
        series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {"baru"})
        series1.Label.TextAlignment = StringAlignment.Far
        series1.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series1.Label.EnableAntialiasing = True
        series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        series2.ArgumentDataMember = "department"
        series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        series2.ValueDataMembers.AddRange(New String() {"lama"})
        series2.Label.TextAlignment = StringAlignment.Far
        series2.Label.TextOrientation = DevExpress.XtraCharts.TextOrientation.Horizontal
        series2.Label.EnableAntialiasing = True
        series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True

        ' Set some properties to get a nice-looking chart.
        CType(series1.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        CType(series2.Label, DevExpress.XtraCharts.SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top

        CType(series1.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False
        CType(series2.View, DevExpress.XtraCharts.SideBySideBarSeriesView).ColorEach = False

        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.MinorCount = 1
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Text = "Jumlah"
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.Alignment = StringAlignment.Center
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Title.EnableAntialiasing = True
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Font = New System.Drawing.Font("Tahoma", 10.0!)
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Text = "Department"
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.Alignment = StringAlignment.Center
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Title.EnableAntialiasing = True
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = False
        CType(ccPxLB.Diagram, DevExpress.XtraCharts.XYDiagram).AxisX.QualitativeScaleOptions.AutoGrid = False

        Dim ct As New DevExpress.XtraCharts.ChartTitle()
        ct.EnableAntialiasing = True
        ct.Font = New System.Drawing.Font("Tahoma", 10.0!)
        ct.Text = "Pasien Baru/Lama - " & NamaBulan(CDate(deTanggal.EditValue).Month) & " " & CDate(deTanggal.EditValue).Year
        ct.Alignment = StringAlignment.Center
        ct.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
        ct.TextColor = Color.Black
        ccPxLB.Titles.Clear()
        ccPxLB.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ct})
        ' Dock the chart into its parent and add it to the current form.
        ccPxLB.Dock = DockStyle.Fill
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If ccRegister.Series.Count > 0 Then
            Dim mc As New List(Of DevExpress.XtraCharts.ChartControl)

            mc.Add(ccRegHarian)
            mc.Add(ccRegIGD)
            mc.Add(ccRegDept)
            mc.Add(ccAPS)
            mc.Add(ccASM)
            mc.Add(ccPenyakit)
            mc.Add(ccPxLB)
            mc.Add(ccRegister)
            mc.Add(ccTimeResponRM)

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