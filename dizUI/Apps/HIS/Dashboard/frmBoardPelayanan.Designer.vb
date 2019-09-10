<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoardPelayanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpGrafik = New System.Windows.Forms.TableLayoutPanel()
        Me.ccRegIGD = New DevExpress.XtraCharts.ChartControl()
        Me.ccRegHarian = New DevExpress.XtraCharts.ChartControl()
        Me.ccTimeResponRM = New DevExpress.XtraCharts.ChartControl()
        Me.ccAPS = New DevExpress.XtraCharts.ChartControl()
        Me.ccRegister = New DevExpress.XtraCharts.ChartControl()
        Me.ccASM = New DevExpress.XtraCharts.ChartControl()
        Me.ccPenyakit = New DevExpress.XtraCharts.ChartControl()
        Me.ccPxLB = New DevExpress.XtraCharts.ChartControl()
        Me.tlpField = New System.Windows.Forms.TableLayoutPanel()
        Me.deTanggal = New DevExpress.XtraEditors.DateEdit()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.ccRegDept = New DevExpress.XtraCharts.ChartControl()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tlpGrafik.SuspendLayout()
        CType(Me.ccRegIGD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccRegHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccTimeResponRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccAPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccASM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccPenyakit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccPxLB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpField.SuspendLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.ccRegDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 2
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpForm.Size = New System.Drawing.Size(947, 494)
        Me.tlpForm.TabIndex = 0
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pMinimize)
        Me.pTitle.Controls.Add(Me.pMaximize)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(943, 30)
        Me.pTitle.TabIndex = 10
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTitle.Size = New System.Drawing.Size(853, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Aktifitas Pelayanan Medis - Bulanan"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(853, 0)
        Me.pMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMinimize.Name = "pMinimize"
        Me.pMinimize.Size = New System.Drawing.Size(30, 30)
        Me.pMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMinimize.TabIndex = 8
        Me.pMinimize.TabStop = False
        '
        'pMaximize
        '
        Me.pMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMaximize.Image = Global.dizUI.My.Resources.Resources.max_w
        Me.pMaximize.Location = New System.Drawing.Point(883, 0)
        Me.pMaximize.Margin = New System.Windows.Forms.Padding(0)
        Me.pMaximize.Name = "pMaximize"
        Me.pMaximize.Size = New System.Drawing.Size(30, 30)
        Me.pMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pMaximize.TabIndex = 7
        Me.pMaximize.TabStop = False
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(913, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.Panel1)
        Me.pBody.Controls.Add(Me.tlpField)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(943, 464)
        Me.pBody.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.tlpGrafik)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 398)
        Me.Panel1.TabIndex = 18
        '
        'tlpGrafik
        '
        Me.tlpGrafik.AutoSize = True
        Me.tlpGrafik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpGrafik.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpGrafik.ColumnCount = 1
        Me.tlpGrafik.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGrafik.Controls.Add(Me.ccRegDept, 0, 2)
        Me.tlpGrafik.Controls.Add(Me.ccRegIGD, 0, 1)
        Me.tlpGrafik.Controls.Add(Me.ccRegHarian, 0, 0)
        Me.tlpGrafik.Controls.Add(Me.ccTimeResponRM, 0, 5)
        Me.tlpGrafik.Controls.Add(Me.ccAPS, 0, 4)
        Me.tlpGrafik.Controls.Add(Me.ccRegister, 0, 3)
        Me.tlpGrafik.Controls.Add(Me.ccASM, 0, 6)
        Me.tlpGrafik.Controls.Add(Me.ccPenyakit, 0, 7)
        Me.tlpGrafik.Controls.Add(Me.ccPxLB, 0, 8)
        Me.tlpGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpGrafik.Location = New System.Drawing.Point(0, 0)
        Me.tlpGrafik.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpGrafik.Name = "tlpGrafik"
        Me.tlpGrafik.RowCount = 9
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpGrafik.Size = New System.Drawing.Size(926, 2250)
        Me.tlpGrafik.TabIndex = 18
        '
        'ccRegIGD
        '
        Me.ccRegIGD.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccRegIGD.CacheToMemory = True
        Me.ccRegIGD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccRegIGD.Legend.Name = "Default Legend"
        Me.ccRegIGD.Location = New System.Drawing.Point(0, 250)
        Me.ccRegIGD.Margin = New System.Windows.Forms.Padding(0)
        Me.ccRegIGD.Name = "ccRegIGD"
        Me.ccRegIGD.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccRegIGD.Size = New System.Drawing.Size(926, 250)
        Me.ccRegIGD.TabIndex = 22
        '
        'ccRegHarian
        '
        Me.ccRegHarian.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccRegHarian.CacheToMemory = True
        Me.ccRegHarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccRegHarian.Legend.Name = "Default Legend"
        Me.ccRegHarian.Location = New System.Drawing.Point(0, 0)
        Me.ccRegHarian.Margin = New System.Windows.Forms.Padding(0)
        Me.ccRegHarian.Name = "ccRegHarian"
        Me.ccRegHarian.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccRegHarian.Size = New System.Drawing.Size(926, 250)
        Me.ccRegHarian.TabIndex = 21
        '
        'ccTimeResponRM
        '
        Me.ccTimeResponRM.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccTimeResponRM.CacheToMemory = True
        Me.ccTimeResponRM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccTimeResponRM.Legend.Name = "Default Legend"
        Me.ccTimeResponRM.Location = New System.Drawing.Point(0, 1250)
        Me.ccTimeResponRM.Margin = New System.Windows.Forms.Padding(0)
        Me.ccTimeResponRM.Name = "ccTimeResponRM"
        Me.ccTimeResponRM.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccTimeResponRM.Size = New System.Drawing.Size(926, 250)
        Me.ccTimeResponRM.TabIndex = 19
        '
        'ccAPS
        '
        Me.ccAPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccAPS.CacheToMemory = True
        Me.ccAPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccAPS.Legend.Name = "Default Legend"
        Me.ccAPS.Location = New System.Drawing.Point(0, 1000)
        Me.ccAPS.Margin = New System.Windows.Forms.Padding(0)
        Me.ccAPS.Name = "ccAPS"
        Me.ccAPS.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccAPS.Size = New System.Drawing.Size(926, 250)
        Me.ccAPS.TabIndex = 18
        '
        'ccRegister
        '
        Me.ccRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccRegister.CacheToMemory = True
        Me.ccRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccRegister.Legend.Name = "Default Legend"
        Me.ccRegister.Location = New System.Drawing.Point(0, 750)
        Me.ccRegister.Margin = New System.Windows.Forms.Padding(0)
        Me.ccRegister.Name = "ccRegister"
        Me.ccRegister.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccRegister.Size = New System.Drawing.Size(926, 250)
        Me.ccRegister.TabIndex = 20
        '
        'ccASM
        '
        Me.ccASM.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccASM.CacheToMemory = True
        Me.ccASM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccASM.Legend.Name = "Default Legend"
        Me.ccASM.Location = New System.Drawing.Point(0, 1500)
        Me.ccASM.Margin = New System.Windows.Forms.Padding(0)
        Me.ccASM.Name = "ccASM"
        Me.ccASM.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccASM.Size = New System.Drawing.Size(926, 250)
        Me.ccASM.TabIndex = 19
        '
        'ccPenyakit
        '
        Me.ccPenyakit.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccPenyakit.CacheToMemory = True
        Me.ccPenyakit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccPenyakit.Legend.Name = "Default Legend"
        Me.ccPenyakit.Location = New System.Drawing.Point(0, 1750)
        Me.ccPenyakit.Margin = New System.Windows.Forms.Padding(0)
        Me.ccPenyakit.Name = "ccPenyakit"
        Me.ccPenyakit.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccPenyakit.Size = New System.Drawing.Size(926, 250)
        Me.ccPenyakit.TabIndex = 19
        '
        'ccPxLB
        '
        Me.ccPxLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccPxLB.CacheToMemory = True
        Me.ccPxLB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccPxLB.Legend.Name = "Default Legend"
        Me.ccPxLB.Location = New System.Drawing.Point(0, 2000)
        Me.ccPxLB.Margin = New System.Windows.Forms.Padding(0)
        Me.ccPxLB.Name = "ccPxLB"
        Me.ccPxLB.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccPxLB.Size = New System.Drawing.Size(926, 250)
        Me.ccPxLB.TabIndex = 19
        '
        'tlpField
        '
        Me.tlpField.AutoSize = True
        Me.tlpField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpField.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpField.ColumnCount = 4
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpField.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpField.Controls.Add(Me.deTanggal, 2, 1)
        Me.tlpField.Controls.Add(Me.lblDepartment, 1, 1)
        Me.tlpField.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpField.Location = New System.Drawing.Point(0, 30)
        Me.tlpField.Name = "tlpField"
        Me.tlpField.RowCount = 3
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpField.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpField.Size = New System.Drawing.Size(943, 36)
        Me.tlpField.TabIndex = 17
        '
        'deTanggal
        '
        Me.deTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggal.EditValue = Nothing
        Me.deTanggal.Location = New System.Drawing.Point(456, 8)
        Me.deTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggal.Name = "deTanggal"
        Me.deTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggal.Properties.Appearance.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.deTanggal.Properties.DisplayFormat.FormatString = "MM-yyyy"
        Me.deTanggal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.EditFormat.FormatString = "MM-yyyy"
        Me.deTanggal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggal.Properties.Mask.EditMask = "MM-yyyy"
        Me.deTanggal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deTanggal.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView
        Me.deTanggal.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView
        Me.deTanggal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggal.Size = New System.Drawing.Size(104, 20)
        Me.deTanggal.TabIndex = 32
        '
        'lblDepartment
        '
        Me.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(372, 11)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(81, 14)
        Me.lblDepartment.TabIndex = 9
        Me.lblDepartment.Text = "Periode Bulan"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Controls.Add(Me.btnRefresh)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(943, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(743, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(843, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblSep5
        '
        Me.lblSep5.BackColor = System.Drawing.Color.Transparent
        Me.lblSep5.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSep5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep5.Location = New System.Drawing.Point(74, 0)
        Me.lblSep5.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSep5.Name = "lblSep5"
        Me.lblSep5.Size = New System.Drawing.Size(16, 1)
        Me.lblSep5.TabIndex = 19
        Me.lblSep5.Text = "|"
        Me.lblSep5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ccRegDept
        '
        Me.ccRegDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ccRegDept.CacheToMemory = True
        Me.ccRegDept.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccRegDept.Legend.Name = "Default Legend"
        Me.ccRegDept.Location = New System.Drawing.Point(0, 500)
        Me.ccRegDept.Margin = New System.Windows.Forms.Padding(0)
        Me.ccRegDept.Name = "ccRegDept"
        Me.ccRegDept.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ccRegDept.Size = New System.Drawing.Size(926, 250)
        Me.ccRegDept.TabIndex = 21
        '
        'frmBoardPelayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 494)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBoardPelayanan"
        Me.ShowInTaskbar = False
        Me.Text = "Aktifitas Pelayanan Medis - Bulanan"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tlpGrafik.ResumeLayout(False)
        CType(Me.ccRegIGD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccRegHarian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccTimeResponRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccAPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccASM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccPenyakit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccPxLB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpField.ResumeLayout(False)
        Me.tlpField.PerformLayout()
        CType(Me.deTanggal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.ccRegDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Public WithEvents tlpField As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Public WithEvents btnRefresh As Button
    Friend WithEvents deTanggal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ccRegister As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccAPS As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccPxLB As DevExpress.XtraCharts.ChartControl
    Public WithEvents tlpGrafik As TableLayoutPanel
    Friend WithEvents ccPenyakit As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccASM As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccTimeResponRM As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Panel1 As Panel
    Public WithEvents btnExport As Button
    Friend WithEvents ccRegHarian As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccRegIGD As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ccRegDept As DevExpress.XtraCharts.ChartControl
End Class
