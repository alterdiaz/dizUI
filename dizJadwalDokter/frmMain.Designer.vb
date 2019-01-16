<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pNote = New System.Windows.Forms.Panel()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pboLogo = New System.Windows.Forms.PictureBox()
        Me.lblJudulKecil = New System.Windows.Forms.Label()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSpecialty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcApp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.pNote.SuspendLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pNote
        '
        Me.pNote.Controls.Add(Me.lblNote)
        Me.pNote.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pNote.Location = New System.Drawing.Point(0, 728)
        Me.pNote.Margin = New System.Windows.Forms.Padding(0)
        Me.pNote.Name = "pNote"
        Me.pNote.Size = New System.Drawing.Size(1366, 40)
        Me.pNote.TabIndex = 18
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.White
        Me.lblNote.Location = New System.Drawing.Point(0, 3)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(0, 33)
        Me.lblNote.TabIndex = 7
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWaktu
        '
        Me.lblWaktu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWaktu.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lblWaktu.ForeColor = System.Drawing.Color.Transparent
        Me.lblWaktu.Location = New System.Drawing.Point(1144, 0)
        Me.lblWaktu.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(206, 64)
        Me.lblWaktu.TabIndex = 16
        Me.lblWaktu.Text = "Mar, 00 0000"
        Me.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 2
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(1147, 728)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 40)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        Me.btnRefresh.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1267, 728)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'pboLogo
        '
        Me.pboLogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pboLogo.BackColor = System.Drawing.Color.Transparent
        Me.pboLogo.Location = New System.Drawing.Point(16, 0)
        Me.pboLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pboLogo.Name = "pboLogo"
        Me.pboLogo.Size = New System.Drawing.Size(206, 64)
        Me.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pboLogo.TabIndex = 11
        Me.pboLogo.TabStop = False
        '
        'lblJudulKecil
        '
        Me.lblJudulKecil.AutoSize = True
        Me.lblJudulKecil.BackColor = System.Drawing.Color.Transparent
        Me.lblJudulKecil.Font = New System.Drawing.Font("Lucida Console", 20.0!)
        Me.lblJudulKecil.ForeColor = System.Drawing.Color.Black
        Me.lblJudulKecil.Location = New System.Drawing.Point(9, 48)
        Me.lblJudulKecil.Margin = New System.Windows.Forms.Padding(0)
        Me.lblJudulKecil.Name = "lblJudulKecil"
        Me.lblJudulKecil.Size = New System.Drawing.Size(348, 27)
        Me.lblJudulKecil.TabIndex = 6
        Me.lblJudulKecil.Text = "JADWAL PRAKTEK DOKTER"
        Me.lblJudulKecil.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Lucida Console", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.Black
        Me.lblJudul.Location = New System.Drawing.Point(9, 8)
        Me.lblJudul.Margin = New System.Windows.Forms.Padding(0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(392, 40)
        Me.lblJudul.TabIndex = 5
        Me.lblJudul.Text = "DOCTOR SCHEDULE"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'gcData
        '
        Me.gcData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcData.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcData.Location = New System.Drawing.Point(0, 76)
        Me.gcData.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.gcData.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(4)
        Me.gcData.Name = "gcData"
        Me.gcData.Padding = New System.Windows.Forms.Padding(4)
        Me.gcData.Size = New System.Drawing.Size(1366, 650)
        Me.gcData.TabIndex = 4
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.Black
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.gvData.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvData.Appearance.EvenRow.Image = Global.dizJadwalDokter.My.Resources.Resources.odd
        Me.gvData.Appearance.EvenRow.Options.UseForeColor = True
        Me.gvData.Appearance.EvenRow.Options.UseImage = True
        Me.gvData.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent
        Me.gvData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvData.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.gvData.Appearance.HeaderPanel.Image = Global.dizJadwalDokter.My.Resources.Resources.header
        Me.gvData.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gvData.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvData.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gvData.Appearance.HeaderPanel.Options.UseImage = True
        Me.gvData.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvData.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvData.Appearance.OddRow.ForeColor = System.Drawing.Color.White
        Me.gvData.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gvData.Appearance.OddRow.Image = Global.dizJadwalDokter.My.Resources.Resources.even
        Me.gvData.Appearance.OddRow.Options.UseForeColor = True
        Me.gvData.Appearance.OddRow.Options.UseImage = True
        Me.gvData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvData.ColumnPanelRowHeight = 0
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcName, Me.gcSpecialty, Me.gcTime, Me.gcRoom, Me.gcApp, Me.gcStatus})
        Me.gvData.DetailHeight = 50
        Me.gvData.FixedLineWidth = 1
        Me.gvData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.gvData.GridControl = Me.gcData
        Me.gvData.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled
        Me.gvData.OptionsBehavior.SmartVertScrollBar = False
        Me.gvData.OptionsHint.ShowCellHints = False
        Me.gvData.OptionsHint.ShowColumnHeaderHints = False
        Me.gvData.OptionsHint.ShowFooterHints = False
        Me.gvData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvData.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvData.OptionsSelection.UseIndicatorForSelection = False
        Me.gvData.OptionsView.AllowHtmlDrawGroups = False
        Me.gvData.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvData.OptionsView.ShowIndicator = False
        Me.gvData.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvData.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        Me.gvData.RowHeight = 0
        Me.gvData.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.gvData.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'gcID
        '
        Me.gcID.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcID.AppearanceCell.Options.UseFont = True
        Me.gcID.AppearanceCell.Options.UseTextOptions = True
        Me.gcID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idjadwalparamedis"
        Me.gcID.MinWidth = 10
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.AllowFocus = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcName
        '
        Me.gcName.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.gcName.AppearanceCell.Options.UseFont = True
        Me.gcName.AppearanceCell.Options.UseTextOptions = True
        Me.gcName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcName.Caption = "DOKTER / AHLI"
        Me.gcName.FieldName = "nama"
        Me.gcName.MinWidth = 10
        Me.gcName.Name = "gcName"
        Me.gcName.OptionsColumn.AllowEdit = False
        Me.gcName.OptionsColumn.AllowFocus = False
        Me.gcName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcName.OptionsColumn.ReadOnly = True
        Me.gcName.OptionsFilter.AllowAutoFilter = False
        Me.gcName.OptionsFilter.AllowFilter = False
        Me.gcName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.gcName.Visible = True
        Me.gcName.VisibleIndex = 0
        Me.gcName.Width = 512
        '
        'gcSpecialty
        '
        Me.gcSpecialty.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.gcSpecialty.AppearanceCell.Options.UseFont = True
        Me.gcSpecialty.AppearanceCell.Options.UseTextOptions = True
        Me.gcSpecialty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gcSpecialty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcSpecialty.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcSpecialty.Caption = "SPESIALIS"
        Me.gcSpecialty.FieldName = "spesialis"
        Me.gcSpecialty.MinWidth = 10
        Me.gcSpecialty.Name = "gcSpecialty"
        Me.gcSpecialty.OptionsColumn.AllowEdit = False
        Me.gcSpecialty.OptionsColumn.AllowFocus = False
        Me.gcSpecialty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcSpecialty.OptionsColumn.ReadOnly = True
        Me.gcSpecialty.OptionsFilter.AllowAutoFilter = False
        Me.gcSpecialty.OptionsFilter.AllowFilter = False
        Me.gcSpecialty.Visible = True
        Me.gcSpecialty.VisibleIndex = 1
        Me.gcSpecialty.Width = 320
        '
        'gcTime
        '
        Me.gcTime.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.gcTime.AppearanceCell.Options.UseFont = True
        Me.gcTime.AppearanceCell.Options.UseTextOptions = True
        Me.gcTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcTime.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcTime.Caption = "JAM"
        Me.gcTime.FieldName = "jammulai"
        Me.gcTime.MinWidth = 10
        Me.gcTime.Name = "gcTime"
        Me.gcTime.OptionsColumn.AllowEdit = False
        Me.gcTime.OptionsColumn.AllowFocus = False
        Me.gcTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcTime.OptionsColumn.ReadOnly = True
        Me.gcTime.OptionsFilter.AllowAutoFilter = False
        Me.gcTime.OptionsFilter.AllowFilter = False
        Me.gcTime.Visible = True
        Me.gcTime.VisibleIndex = 2
        Me.gcTime.Width = 137
        '
        'gcRoom
        '
        Me.gcRoom.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.gcRoom.AppearanceCell.Options.UseFont = True
        Me.gcRoom.AppearanceCell.Options.UseTextOptions = True
        Me.gcRoom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcRoom.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcRoom.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcRoom.Caption = "RUANG"
        Me.gcRoom.FieldName = "lokasi"
        Me.gcRoom.MinWidth = 10
        Me.gcRoom.Name = "gcRoom"
        Me.gcRoom.OptionsColumn.AllowEdit = False
        Me.gcRoom.OptionsColumn.AllowFocus = False
        Me.gcRoom.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcRoom.OptionsColumn.ReadOnly = True
        Me.gcRoom.OptionsFilter.AllowAutoFilter = False
        Me.gcRoom.OptionsFilter.AllowFilter = False
        Me.gcRoom.Visible = True
        Me.gcRoom.VisibleIndex = 3
        Me.gcRoom.Width = 121
        '
        'gcApp
        '
        Me.gcApp.Caption = "NOMOR"
        Me.gcApp.FieldName = "antrian"
        Me.gcApp.Name = "gcApp"
        Me.gcApp.OptionsColumn.AllowEdit = False
        Me.gcApp.OptionsColumn.AllowFocus = False
        Me.gcApp.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcApp.OptionsColumn.ReadOnly = True
        Me.gcApp.OptionsFilter.AllowAutoFilter = False
        Me.gcApp.OptionsFilter.AllowFilter = False
        Me.gcApp.Visible = True
        Me.gcApp.VisibleIndex = 4
        Me.gcApp.Width = 132
        '
        'gcStatus
        '
        Me.gcStatus.AppearanceCell.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.gcStatus.AppearanceCell.Options.UseFont = True
        Me.gcStatus.AppearanceCell.Options.UseTextOptions = True
        Me.gcStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gcStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.gcStatus.Caption = "STATUS"
        Me.gcStatus.FieldName = "status"
        Me.gcStatus.MinWidth = 10
        Me.gcStatus.Name = "gcStatus"
        Me.gcStatus.OptionsColumn.AllowEdit = False
        Me.gcStatus.OptionsColumn.AllowFocus = False
        Me.gcStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.gcStatus.OptionsColumn.ReadOnly = True
        Me.gcStatus.OptionsFilter.AllowAutoFilter = False
        Me.gcStatus.OptionsFilter.AllowFilter = False
        Me.gcStatus.Visible = True
        Me.gcStatus.VisibleIndex = 5
        Me.gcStatus.Width = 144
        '
        'tmr
        '
        Me.tmr.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.gcData)
        Me.Controls.Add(Me.lblJudulKecil)
        Me.Controls.Add(Me.pboLogo)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.pNote)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitor Schedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pNote.ResumeLayout(False)
        Me.pNote.PerformLayout()
        CType(Me.pboLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pboLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblJudulKecil As System.Windows.Forms.Label
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents gcSpecialty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblWaktu As System.Windows.Forms.Label
    Friend WithEvents pNote As System.Windows.Forms.Panel
    Friend WithEvents gcApp As DevExpress.XtraGrid.Columns.GridColumn

End Class
