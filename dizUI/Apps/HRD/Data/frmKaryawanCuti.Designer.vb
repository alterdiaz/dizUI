<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKaryawanCuti
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
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn136 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn99 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn100 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpJadwal2 = New System.Windows.Forms.TableLayoutPanel()
        Me.teRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.slueKaryawan = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.slueView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lueKehadiran = New DevExpress.XtraEditors.LookUpEdit()
        Me.tlpJadwal1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTanggalAkhir = New System.Windows.Forms.Label()
        Me.deTanggalAkhir = New DevExpress.XtraEditors.DateEdit()
        Me.lueJenisTanggal = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deTanggalAwal = New DevExpress.XtraEditors.DateEdit()
        Me.lblTanggalAwal = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal2.SuspendLayout()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKehadiran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal1.SuspendLayout()
        CType(Me.deTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJenisTanggal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
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
        Me.tlpForm.Size = New System.Drawing.Size(790, 408)
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
        Me.pTitle.Size = New System.Drawing.Size(786, 30)
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
        Me.lblTitle.Size = New System.Drawing.Size(696, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Karyawan Cuti"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pMinimize
        '
        Me.pMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.pMinimize.Image = Global.dizUI.My.Resources.Resources.min_w
        Me.pMinimize.Location = New System.Drawing.Point(696, 0)
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
        Me.pMaximize.Location = New System.Drawing.Point(726, 0)
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
        Me.pExit.Location = New System.Drawing.Point(756, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 9
        Me.pExit.TabStop = False
        '
        'pBody
        '
        Me.pBody.Controls.Add(Me.gcData)
        Me.pBody.Controls.Add(Me.tlpJadwal2)
        Me.pBody.Controls.Add(Me.tlpJadwal1)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcData.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gcData.Location = New System.Drawing.Point(0, 168)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(786, 210)
        Me.gcData.TabIndex = 131
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn44, Me.GridColumn136, Me.GridColumn47, Me.GridColumn4, Me.GridColumn3, Me.GridColumn2, Me.GridColumn99, Me.GridColumn100})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsView.ColumnAutoWidth = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.RowAutoHeight = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        Me.gvData.OptionsView.ShowViewCaption = True
        Me.gvData.ViewCaption = "Jadwal Dokter"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "idvacation"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn44
        '
        Me.GridColumn44.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn44.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn44.Caption = "ID"
        Me.GridColumn44.FieldName = "idreff"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.AllowEdit = False
        Me.GridColumn44.OptionsColumn.ReadOnly = True
        '
        'GridColumn136
        '
        Me.GridColumn136.Caption = "kehadiran"
        Me.GridColumn136.FieldName = "kehadiran"
        Me.GridColumn136.Name = "GridColumn136"
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "isdeleted"
        Me.GridColumn47.FieldName = "isdeleted"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.OptionsColumn.AllowEdit = False
        Me.GridColumn47.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Tanggal Cuti"
        Me.GridColumn4.FieldName = "vacationdate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Nama Karyawan"
        Me.GridColumn3.FieldName = "karyawan"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Kehadiran"
        Me.GridColumn2.FieldName = "stathadir"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn99
        '
        Me.GridColumn99.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn99.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn99.Caption = "Status Data"
        Me.GridColumn99.FieldName = "statdata"
        Me.GridColumn99.Name = "GridColumn99"
        Me.GridColumn99.OptionsColumn.AllowEdit = False
        Me.GridColumn99.OptionsColumn.ReadOnly = True
        Me.GridColumn99.Visible = True
        Me.GridColumn99.VisibleIndex = 3
        Me.GridColumn99.Width = 67
        '
        'GridColumn100
        '
        Me.GridColumn100.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn100.Caption = "Keterangan"
        Me.GridColumn100.FieldName = "remarks"
        Me.GridColumn100.Name = "GridColumn100"
        Me.GridColumn100.OptionsColumn.AllowEdit = False
        Me.GridColumn100.OptionsColumn.ReadOnly = True
        Me.GridColumn100.Visible = True
        Me.GridColumn100.VisibleIndex = 4
        '
        'tlpJadwal2
        '
        Me.tlpJadwal2.AutoSize = True
        Me.tlpJadwal2.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpJadwal2.ColumnCount = 4
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.Controls.Add(Me.teRemarks, 2, 2)
        Me.tlpJadwal2.Controls.Add(Me.slueKaryawan, 2, 0)
        Me.tlpJadwal2.Controls.Add(Me.Label2, 1, 2)
        Me.tlpJadwal2.Controls.Add(Me.Label1, 1, 0)
        Me.tlpJadwal2.Controls.Add(Me.Label15, 1, 1)
        Me.tlpJadwal2.Controls.Add(Me.lueKehadiran, 2, 1)
        Me.tlpJadwal2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal2.Location = New System.Drawing.Point(0, 90)
        Me.tlpJadwal2.Name = "tlpJadwal2"
        Me.tlpJadwal2.RowCount = 4
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpJadwal2.Size = New System.Drawing.Size(786, 78)
        Me.tlpJadwal2.TabIndex = 19
        '
        'teRemarks
        '
        Me.teRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teRemarks.Location = New System.Drawing.Point(243, 50)
        Me.teRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.teRemarks.Name = "teRemarks"
        Me.teRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.teRemarks.Properties.Appearance.Options.UseFont = True
        Me.teRemarks.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teRemarks.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teRemarks.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teRemarks.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teRemarks.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teRemarks.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teRemarks.Properties.MaxLength = 300
        Me.teRemarks.Properties.NullText = "[Belum Diisi]"
        Me.teRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teRemarks.Size = New System.Drawing.Size(277, 20)
        Me.teRemarks.TabIndex = 19
        Me.teRemarks.Tag = "namapasien"
        '
        'slueKaryawan
        '
        Me.slueKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.slueKaryawan.Location = New System.Drawing.Point(243, 2)
        Me.slueKaryawan.Margin = New System.Windows.Forms.Padding(0)
        Me.slueKaryawan.Name = "slueKaryawan"
        Me.slueKaryawan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueKaryawan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slueKaryawan.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.slueKaryawan.Properties.Appearance.Options.UseBackColor = True
        Me.slueKaryawan.Properties.Appearance.Options.UseFont = True
        Me.slueKaryawan.Properties.Appearance.Options.UseForeColor = True
        Me.slueKaryawan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.slueKaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.slueKaryawan.Properties.NullText = "[Isian belum dipilih]"
        Me.slueKaryawan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.slueKaryawan.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple
        Me.slueKaryawan.Properties.PopupFindMode = DevExpress.XtraEditors.FindMode.Always
        Me.slueKaryawan.Properties.PopupView = Me.slueView
        Me.slueKaryawan.Properties.ShowFooter = False
        Me.slueKaryawan.Properties.ShowPopupShadow = False
        Me.slueKaryawan.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        Me.slueKaryawan.Size = New System.Drawing.Size(277, 20)
        Me.slueKaryawan.TabIndex = 24
        '
        'slueView
        '
        Me.slueView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.slueView.Appearance.EvenRow.Options.UseBackColor = True
        Me.slueView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.slueView.Appearance.OddRow.Options.UseBackColor = True
        Me.slueView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.slueView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.slueView.Name = "slueView"
        Me.slueView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.slueView.OptionsView.EnableAppearanceEvenRow = True
        Me.slueView.OptionsView.EnableAppearanceOddRow = True
        Me.slueView.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID"
        Me.GridColumn8.FieldName = "id"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Content"
        Me.GridColumn9.FieldName = "content"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Remarks"
        Me.GridColumn10.FieldName = "remarks"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Keterangan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Karyawan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(150, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 14)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Jenis Kehadiran"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueKehadiran
        '
        Me.lueKehadiran.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKehadiran.Location = New System.Drawing.Point(243, 26)
        Me.lueKehadiran.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKehadiran.Name = "lueKehadiran"
        Me.lueKehadiran.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueKehadiran.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKehadiran.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKehadiran.Properties.Appearance.Options.UseBackColor = True
        Me.lueKehadiran.Properties.Appearance.Options.UseFont = True
        Me.lueKehadiran.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKehadiran.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKehadiran.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueKehadiran.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKehadiran.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKehadiran.Size = New System.Drawing.Size(150, 20)
        Me.lueKehadiran.TabIndex = 115
        Me.lueKehadiran.Tag = "idjadwalsesi"
        '
        'tlpJadwal1
        '
        Me.tlpJadwal1.AutoSize = True
        Me.tlpJadwal1.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.tlpJadwal1.ColumnCount = 6
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.Controls.Add(Me.lblTanggalAkhir, 3, 2)
        Me.tlpJadwal1.Controls.Add(Me.deTanggalAkhir, 4, 2)
        Me.tlpJadwal1.Controls.Add(Me.lueJenisTanggal, 2, 1)
        Me.tlpJadwal1.Controls.Add(Me.Label6, 1, 1)
        Me.tlpJadwal1.Controls.Add(Me.deTanggalAwal, 2, 2)
        Me.tlpJadwal1.Controls.Add(Me.lblTanggalAwal, 1, 2)
        Me.tlpJadwal1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal1.Location = New System.Drawing.Point(0, 30)
        Me.tlpJadwal1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpJadwal1.Name = "tlpJadwal1"
        Me.tlpJadwal1.RowCount = 4
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal1.Size = New System.Drawing.Size(786, 60)
        Me.tlpJadwal1.TabIndex = 129
        '
        'lblTanggalAkhir
        '
        Me.lblTanggalAkhir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTanggalAkhir.AutoSize = True
        Me.lblTanggalAkhir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTanggalAkhir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalAkhir.Location = New System.Drawing.Point(470, 35)
        Me.lblTanggalAkhir.Name = "lblTanggalAkhir"
        Me.lblTanggalAkhir.Size = New System.Drawing.Size(50, 14)
        Me.lblTanggalAkhir.TabIndex = 118
        Me.lblTanggalAkhir.Text = "Tanggal"
        Me.lblTanggalAkhir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalAkhir
        '
        Me.deTanggalAkhir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalAkhir.EditValue = Nothing
        Me.deTanggalAkhir.Location = New System.Drawing.Point(523, 32)
        Me.deTanggalAkhir.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalAkhir.Name = "deTanggalAkhir"
        Me.deTanggalAkhir.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalAkhir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalAkhir.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalAkhir.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalAkhir.Properties.Appearance.Options.UseFont = True
        Me.deTanggalAkhir.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalAkhir.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalAkhir.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAkhir.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalAkhir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalAkhir.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalAkhir.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggalAkhir.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalAkhir.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalAkhir.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalAkhir.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalAkhir.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalAkhir.Size = New System.Drawing.Size(110, 20)
        Me.deTanggalAkhir.TabIndex = 119
        Me.deTanggalAkhir.Tag = "tanggalmulai"
        '
        'lueJenisTanggal
        '
        Me.lueJenisTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJenisTanggal.Location = New System.Drawing.Point(243, 8)
        Me.lueJenisTanggal.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJenisTanggal.Name = "lueJenisTanggal"
        Me.lueJenisTanggal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJenisTanggal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJenisTanggal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJenisTanggal.Properties.Appearance.Options.UseBackColor = True
        Me.lueJenisTanggal.Properties.Appearance.Options.UseFont = True
        Me.lueJenisTanggal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJenisTanggal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJenisTanggal.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJenisTanggal.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJenisTanggal.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJenisTanggal.Size = New System.Drawing.Size(150, 20)
        Me.lueJenisTanggal.TabIndex = 116
        Me.lueJenisTanggal.Tag = "idjadwalsesi"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 14)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Jenis Tanggal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deTanggalAwal
        '
        Me.deTanggalAwal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deTanggalAwal.EditValue = Nothing
        Me.deTanggalAwal.Location = New System.Drawing.Point(243, 32)
        Me.deTanggalAwal.Margin = New System.Windows.Forms.Padding(0)
        Me.deTanggalAwal.Name = "deTanggalAwal"
        Me.deTanggalAwal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalAwal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deTanggalAwal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deTanggalAwal.Properties.Appearance.Options.UseBackColor = True
        Me.deTanggalAwal.Properties.Appearance.Options.UseFont = True
        Me.deTanggalAwal.Properties.Appearance.Options.UseForeColor = True
        Me.deTanggalAwal.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceFocused.Options.UseFont = True
        Me.deTanggalAwal.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deTanggalAwal.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deTanggalAwal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deTanggalAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deTanggalAwal.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deTanggalAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deTanggalAwal.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deTanggalAwal.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalAwal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalAwal.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deTanggalAwal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deTanggalAwal.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deTanggalAwal.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deTanggalAwal.Size = New System.Drawing.Size(110, 20)
        Me.deTanggalAwal.TabIndex = 118
        Me.deTanggalAwal.Tag = "tanggalmulai"
        '
        'lblTanggalAwal
        '
        Me.lblTanggalAwal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTanggalAwal.AutoSize = True
        Me.lblTanggalAwal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTanggalAwal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalAwal.Location = New System.Drawing.Point(190, 35)
        Me.lblTanggalAwal.Name = "lblTanggalAwal"
        Me.lblTanggalAwal.Size = New System.Drawing.Size(50, 14)
        Me.lblTanggalAwal.TabIndex = 117
        Me.lblTanggalAwal.Text = "Tanggal"
        Me.lblTanggalAwal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
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
        Me.btnExport.Location = New System.Drawing.Point(546, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(706, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
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
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(646, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmKaryawanCuti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.color.fromargb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKaryawanCuti"
        Me.ShowInTaskbar = False
        Me.Text = "Karyawan Cuti"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal2.ResumeLayout(False)
        Me.tlpJadwal2.PerformLayout()
        CType(Me.teRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slueView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKehadiran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal1.ResumeLayout(False)
        Me.tlpJadwal1.PerformLayout()
        CType(Me.deTanggalAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJenisTanggal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deTanggalAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tlpJadwal1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lueKehadiran As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn136 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn99 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTanggalAwal As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deTanggalAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tlpJadwal2 As TableLayoutPanel
    Friend WithEvents lueJenisTanggal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTanggalAkhir As Label
    Friend WithEvents deTanggalAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents slueKaryawan As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents slueView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teRemarks As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnNew As Button
End Class
