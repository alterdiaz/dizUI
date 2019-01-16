<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParamedisJadwal
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
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn99 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn130 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn100 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn101 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn103 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn114 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn115 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn116 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn117 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn118 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn119 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn98 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn120 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn121 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn122 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn123 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn124 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn125 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn126 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn127 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rimeJadwalRemarks = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tlpJadwal2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.meJadwalRemarks = New DevExpress.XtraEditors.MemoEdit()
        Me.tlpJadwal1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lueUnit = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lueParamedis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsJadwalParamedisSMS = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.deJadwalSelesai = New DevExpress.XtraEditors.DateEdit()
        Me.deJadwalMulai = New DevExpress.XtraEditors.DateEdit()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lueJadwalSesi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ccboJadwalHari = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.teJamSelesai = New DevExpress.XtraEditors.TimeEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.teJamMulai = New DevExpress.XtraEditors.TimeEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tsJadwalMonitor = New DevExpress.XtraEditors.ToggleSwitch()
        Me.tsJadwalPasienSMS = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.seJadwalDurasi = New DevExpress.XtraEditors.SpinEdit()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.seJadwalMaxApp = New DevExpress.XtraEditors.SpinEdit()
        Me.lueJadwalLokasi = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueSpesialis = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        Me.btnDeletePermanen = New System.Windows.Forms.Button()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rimeJadwalRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal2.SuspendLayout()
        CType(Me.meJadwalRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpJadwal1.SuspendLayout()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsJadwalParamedisSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deJadwalSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deJadwalSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deJadwalMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deJadwalMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJadwalSesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccboJadwalHari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJamSelesai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teJamMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsJadwalMonitor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tsJadwalPasienSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seJadwalDurasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seJadwalMaxApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueJadwalLokasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Jadwal Dokter"
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
        Me.gcData.Location = New System.Drawing.Point(0, 282)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Margin = New System.Windows.Forms.Padding(0)
        Me.gcData.Name = "gcData"
        Me.gcData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rimeJadwalRemarks})
        Me.gcData.Size = New System.Drawing.Size(786, 96)
        Me.gcData.TabIndex = 131
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn44, Me.GridColumn136, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn51, Me.GridColumn52, Me.GridColumn66, Me.GridColumn4, Me.GridColumn3, Me.GridColumn2, Me.GridColumn99, Me.GridColumn130, Me.GridColumn100, Me.GridColumn101, Me.GridColumn103, Me.GridColumn114, Me.GridColumn115, Me.GridColumn116, Me.GridColumn117, Me.GridColumn118, Me.GridColumn119, Me.GridColumn65, Me.GridColumn98, Me.GridColumn120, Me.GridColumn121, Me.GridColumn122, Me.GridColumn123, Me.GridColumn124, Me.GridColumn125, Me.GridColumn126, Me.GridColumn127})
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
        Me.GridColumn1.Caption = "ID Unit"
        Me.GridColumn1.FieldName = "idunit"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn44
        '
        Me.GridColumn44.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn44.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn44.Caption = "ID"
        Me.GridColumn44.FieldName = "idparamedisjadwal"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.AllowEdit = False
        Me.GridColumn44.OptionsColumn.ReadOnly = True
        '
        'GridColumn136
        '
        Me.GridColumn136.Caption = "ID ParamedisSpesialis"
        Me.GridColumn136.FieldName = "idparamedisspesialis"
        Me.GridColumn136.Name = "GridColumn136"
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "ID Sesi"
        Me.GridColumn47.FieldName = "idsesi"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.OptionsColumn.AllowEdit = False
        Me.GridColumn47.OptionsColumn.ReadOnly = True
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "ID Lokasi"
        Me.GridColumn48.FieldName = "idlokasi"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.AllowEdit = False
        Me.GridColumn48.OptionsColumn.ReadOnly = True
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "isparamedissms"
        Me.GridColumn49.FieldName = "isparamedissms"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.OptionsColumn.AllowEdit = False
        Me.GridColumn49.OptionsColumn.ReadOnly = True
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "ispasiensms"
        Me.GridColumn51.FieldName = "ispasiensms"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.OptionsColumn.AllowEdit = False
        Me.GridColumn51.OptionsColumn.ReadOnly = True
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "ismonitor"
        Me.GridColumn52.FieldName = "ismonitor"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.OptionsColumn.AllowEdit = False
        Me.GridColumn52.OptionsColumn.ReadOnly = True
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "isdeleted"
        Me.GridColumn66.FieldName = "isdeleted"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.OptionsColumn.AllowEdit = False
        Me.GridColumn66.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Unit"
        Me.GridColumn4.FieldName = "unit"
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
        Me.GridColumn3.Caption = "Spesialis"
        Me.GridColumn3.FieldName = "spesialis"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Paramedis"
        Me.GridColumn2.FieldName = "nama"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn99
        '
        Me.GridColumn99.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn99.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn99.Caption = "Sesi"
        Me.GridColumn99.FieldName = "sesi"
        Me.GridColumn99.Name = "GridColumn99"
        Me.GridColumn99.OptionsColumn.AllowEdit = False
        Me.GridColumn99.OptionsColumn.ReadOnly = True
        Me.GridColumn99.Visible = True
        Me.GridColumn99.VisibleIndex = 3
        Me.GridColumn99.Width = 67
        '
        'GridColumn130
        '
        Me.GridColumn130.Caption = "Hari"
        Me.GridColumn130.FieldName = "hari"
        Me.GridColumn130.Name = "GridColumn130"
        '
        'GridColumn100
        '
        Me.GridColumn100.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn100.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn100.Caption = "Ruang"
        Me.GridColumn100.FieldName = "lokasi"
        Me.GridColumn100.Name = "GridColumn100"
        Me.GridColumn100.OptionsColumn.AllowEdit = False
        Me.GridColumn100.OptionsColumn.ReadOnly = True
        Me.GridColumn100.Visible = True
        Me.GridColumn100.VisibleIndex = 4
        '
        'GridColumn101
        '
        Me.GridColumn101.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn101.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn101.Caption = "Minggu"
        Me.GridColumn101.FieldName = "minggu"
        Me.GridColumn101.Name = "GridColumn101"
        Me.GridColumn101.OptionsColumn.AllowEdit = False
        Me.GridColumn101.OptionsColumn.ReadOnly = True
        Me.GridColumn101.Visible = True
        Me.GridColumn101.VisibleIndex = 11
        '
        'GridColumn103
        '
        Me.GridColumn103.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn103.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn103.Caption = "Senin"
        Me.GridColumn103.FieldName = "senin"
        Me.GridColumn103.Name = "GridColumn103"
        Me.GridColumn103.OptionsColumn.AllowEdit = False
        Me.GridColumn103.OptionsColumn.ReadOnly = True
        Me.GridColumn103.Visible = True
        Me.GridColumn103.VisibleIndex = 12
        '
        'GridColumn114
        '
        Me.GridColumn114.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn114.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn114.Caption = "Selasa"
        Me.GridColumn114.FieldName = "selasa"
        Me.GridColumn114.Name = "GridColumn114"
        Me.GridColumn114.OptionsColumn.AllowEdit = False
        Me.GridColumn114.OptionsColumn.ReadOnly = True
        Me.GridColumn114.Visible = True
        Me.GridColumn114.VisibleIndex = 13
        '
        'GridColumn115
        '
        Me.GridColumn115.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn115.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn115.Caption = "Rabu"
        Me.GridColumn115.FieldName = "rabu"
        Me.GridColumn115.Name = "GridColumn115"
        Me.GridColumn115.OptionsColumn.AllowEdit = False
        Me.GridColumn115.OptionsColumn.ReadOnly = True
        Me.GridColumn115.Visible = True
        Me.GridColumn115.VisibleIndex = 14
        '
        'GridColumn116
        '
        Me.GridColumn116.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn116.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn116.Caption = "Status Data"
        Me.GridColumn116.FieldName = "statdata"
        Me.GridColumn116.Name = "GridColumn116"
        Me.GridColumn116.OptionsColumn.AllowEdit = False
        Me.GridColumn116.OptionsColumn.ReadOnly = True
        Me.GridColumn116.Visible = True
        Me.GridColumn116.VisibleIndex = 21
        '
        'GridColumn117
        '
        Me.GridColumn117.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn117.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn117.Caption = "Kamis"
        Me.GridColumn117.FieldName = "kamis"
        Me.GridColumn117.Name = "GridColumn117"
        Me.GridColumn117.OptionsColumn.AllowEdit = False
        Me.GridColumn117.OptionsColumn.ReadOnly = True
        Me.GridColumn117.Visible = True
        Me.GridColumn117.VisibleIndex = 15
        '
        'GridColumn118
        '
        Me.GridColumn118.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn118.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn118.Caption = "Jumat"
        Me.GridColumn118.FieldName = "jumat"
        Me.GridColumn118.Name = "GridColumn118"
        Me.GridColumn118.OptionsColumn.AllowEdit = False
        Me.GridColumn118.OptionsColumn.ReadOnly = True
        Me.GridColumn118.Visible = True
        Me.GridColumn118.VisibleIndex = 16
        Me.GridColumn118.Width = 89
        '
        'GridColumn119
        '
        Me.GridColumn119.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn119.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn119.Caption = "Sabtu"
        Me.GridColumn119.FieldName = "sabtu"
        Me.GridColumn119.Name = "GridColumn119"
        Me.GridColumn119.OptionsColumn.AllowEdit = False
        Me.GridColumn119.OptionsColumn.ReadOnly = True
        Me.GridColumn119.Visible = True
        Me.GridColumn119.VisibleIndex = 17
        '
        'GridColumn65
        '
        Me.GridColumn65.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn65.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn65.Caption = "Tgl. Mulai"
        Me.GridColumn65.FieldName = "tanggalmulai"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.OptionsColumn.AllowEdit = False
        Me.GridColumn65.OptionsColumn.ReadOnly = True
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 5
        '
        'GridColumn98
        '
        Me.GridColumn98.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn98.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn98.Caption = "Tgl. Selesai"
        Me.GridColumn98.FieldName = "tanggalselesai"
        Me.GridColumn98.Name = "GridColumn98"
        Me.GridColumn98.OptionsColumn.AllowEdit = False
        Me.GridColumn98.OptionsColumn.ReadOnly = True
        Me.GridColumn98.Visible = True
        Me.GridColumn98.VisibleIndex = 6
        '
        'GridColumn120
        '
        Me.GridColumn120.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn120.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn120.Caption = "Jam Mulai"
        Me.GridColumn120.FieldName = "jammulai"
        Me.GridColumn120.Name = "GridColumn120"
        Me.GridColumn120.OptionsColumn.AllowEdit = False
        Me.GridColumn120.OptionsColumn.ReadOnly = True
        Me.GridColumn120.Visible = True
        Me.GridColumn120.VisibleIndex = 7
        '
        'GridColumn121
        '
        Me.GridColumn121.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn121.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn121.Caption = "Jam Selesai"
        Me.GridColumn121.FieldName = "jamselesai"
        Me.GridColumn121.Name = "GridColumn121"
        Me.GridColumn121.OptionsColumn.AllowEdit = False
        Me.GridColumn121.OptionsColumn.ReadOnly = True
        Me.GridColumn121.Visible = True
        Me.GridColumn121.VisibleIndex = 8
        '
        'GridColumn122
        '
        Me.GridColumn122.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn122.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn122.Caption = "Max App"
        Me.GridColumn122.FieldName = "maxapp"
        Me.GridColumn122.Name = "GridColumn122"
        Me.GridColumn122.OptionsColumn.AllowEdit = False
        Me.GridColumn122.OptionsColumn.ReadOnly = True
        Me.GridColumn122.Visible = True
        Me.GridColumn122.VisibleIndex = 9
        '
        'GridColumn123
        '
        Me.GridColumn123.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn123.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn123.Caption = "Durasi"
        Me.GridColumn123.FieldName = "durasi"
        Me.GridColumn123.Name = "GridColumn123"
        Me.GridColumn123.OptionsColumn.AllowEdit = False
        Me.GridColumn123.OptionsColumn.ReadOnly = True
        Me.GridColumn123.Visible = True
        Me.GridColumn123.VisibleIndex = 10
        '
        'GridColumn124
        '
        Me.GridColumn124.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn124.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn124.Caption = "Paramedis SMS"
        Me.GridColumn124.FieldName = "paramedissms"
        Me.GridColumn124.Name = "GridColumn124"
        Me.GridColumn124.OptionsColumn.AllowEdit = False
        Me.GridColumn124.OptionsColumn.ReadOnly = True
        Me.GridColumn124.Visible = True
        Me.GridColumn124.VisibleIndex = 18
        '
        'GridColumn125
        '
        Me.GridColumn125.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn125.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn125.Caption = "Pasien SMS"
        Me.GridColumn125.FieldName = "pasiensms"
        Me.GridColumn125.Name = "GridColumn125"
        Me.GridColumn125.OptionsColumn.AllowEdit = False
        Me.GridColumn125.OptionsColumn.ReadOnly = True
        Me.GridColumn125.Visible = True
        Me.GridColumn125.VisibleIndex = 19
        '
        'GridColumn126
        '
        Me.GridColumn126.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn126.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn126.Caption = "Monitor"
        Me.GridColumn126.FieldName = "monitor"
        Me.GridColumn126.Name = "GridColumn126"
        Me.GridColumn126.OptionsColumn.AllowEdit = False
        Me.GridColumn126.OptionsColumn.ReadOnly = True
        Me.GridColumn126.Visible = True
        Me.GridColumn126.VisibleIndex = 20
        '
        'GridColumn127
        '
        Me.GridColumn127.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn127.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn127.Caption = "Keterangan"
        Me.GridColumn127.ColumnEdit = Me.rimeJadwalRemarks
        Me.GridColumn127.FieldName = "remarks"
        Me.GridColumn127.Name = "GridColumn127"
        Me.GridColumn127.OptionsColumn.AllowEdit = False
        Me.GridColumn127.OptionsColumn.ReadOnly = True
        Me.GridColumn127.Visible = True
        Me.GridColumn127.VisibleIndex = 22
        '
        'rimeJadwalRemarks
        '
        Me.rimeJadwalRemarks.Name = "rimeJadwalRemarks"
        Me.rimeJadwalRemarks.ReadOnly = True
        '
        'tlpJadwal2
        '
        Me.tlpJadwal2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpJadwal2.ColumnCount = 4
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.tlpJadwal2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal2.Controls.Add(Me.Label25, 1, 0)
        Me.tlpJadwal2.Controls.Add(Me.meJadwalRemarks, 2, 0)
        Me.tlpJadwal2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal2.Location = New System.Drawing.Point(0, 228)
        Me.tlpJadwal2.Name = "tlpJadwal2"
        Me.tlpJadwal2.RowCount = 2
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpJadwal2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal2.Size = New System.Drawing.Size(786, 54)
        Me.tlpJadwal2.TabIndex = 130
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(170, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 14)
        Me.Label25.TabIndex = 115
        Me.Label25.Text = "Keterangan"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meJadwalRemarks
        '
        Me.meJadwalRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.meJadwalRemarks.Location = New System.Drawing.Point(243, 0)
        Me.meJadwalRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.meJadwalRemarks.Name = "meJadwalRemarks"
        Me.meJadwalRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meJadwalRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.meJadwalRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.meJadwalRemarks.Properties.Appearance.Options.UseFont = True
        Me.meJadwalRemarks.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meJadwalRemarks.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.meJadwalRemarks.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.meJadwalRemarks.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.meJadwalRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.meJadwalRemarks.Size = New System.Drawing.Size(327, 48)
        Me.meJadwalRemarks.TabIndex = 127
        Me.meJadwalRemarks.Tag = "remarks"
        '
        'tlpJadwal1
        '
        Me.tlpJadwal1.AutoSize = True
        Me.tlpJadwal1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpJadwal1.ColumnCount = 6
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpJadwal1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpJadwal1.Controls.Add(Me.lueUnit, 2, 1)
        Me.tlpJadwal1.Controls.Add(Me.Label5, 1, 1)
        Me.tlpJadwal1.Controls.Add(Me.lueParamedis, 2, 2)
        Me.tlpJadwal1.Controls.Add(Me.Label1, 1, 2)
        Me.tlpJadwal1.Controls.Add(Me.tsJadwalParamedisSMS, 4, 6)
        Me.tlpJadwal1.Controls.Add(Me.Label62, 3, 6)
        Me.tlpJadwal1.Controls.Add(Me.Label60, 1, 6)
        Me.tlpJadwal1.Controls.Add(Me.deJadwalSelesai, 2, 6)
        Me.tlpJadwal1.Controls.Add(Me.deJadwalMulai, 2, 5)
        Me.tlpJadwal1.Controls.Add(Me.Label59, 1, 5)
        Me.tlpJadwal1.Controls.Add(Me.lueJadwalSesi, 2, 3)
        Me.tlpJadwal1.Controls.Add(Me.Label2, 1, 3)
        Me.tlpJadwal1.Controls.Add(Me.ccboJadwalHari, 2, 4)
        Me.tlpJadwal1.Controls.Add(Me.Label15, 1, 4)
        Me.tlpJadwal1.Controls.Add(Me.teJamSelesai, 2, 8)
        Me.tlpJadwal1.Controls.Add(Me.Label4, 1, 8)
        Me.tlpJadwal1.Controls.Add(Me.teJamMulai, 2, 7)
        Me.tlpJadwal1.Controls.Add(Me.Label10, 1, 7)
        Me.tlpJadwal1.Controls.Add(Me.Label23, 3, 8)
        Me.tlpJadwal1.Controls.Add(Me.tsJadwalMonitor, 4, 8)
        Me.tlpJadwal1.Controls.Add(Me.tsJadwalPasienSMS, 4, 7)
        Me.tlpJadwal1.Controls.Add(Me.Label22, 3, 7)
        Me.tlpJadwal1.Controls.Add(Me.seJadwalDurasi, 4, 5)
        Me.tlpJadwal1.Controls.Add(Me.Label61, 3, 5)
        Me.tlpJadwal1.Controls.Add(Me.Label16, 3, 4)
        Me.tlpJadwal1.Controls.Add(Me.seJadwalMaxApp, 4, 4)
        Me.tlpJadwal1.Controls.Add(Me.lueJadwalLokasi, 4, 3)
        Me.tlpJadwal1.Controls.Add(Me.Label3, 3, 3)
        Me.tlpJadwal1.Controls.Add(Me.lueSpesialis, 4, 2)
        Me.tlpJadwal1.Controls.Add(Me.Label18, 3, 2)
        Me.tlpJadwal1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpJadwal1.Location = New System.Drawing.Point(0, 30)
        Me.tlpJadwal1.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpJadwal1.Name = "tlpJadwal1"
        Me.tlpJadwal1.RowCount = 9
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpJadwal1.Size = New System.Drawing.Size(786, 198)
        Me.tlpJadwal1.TabIndex = 129
        '
        'lueUnit
        '
        Me.lueUnit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueUnit.Location = New System.Drawing.Point(243, 8)
        Me.lueUnit.Margin = New System.Windows.Forms.Padding(0)
        Me.lueUnit.Name = "lueUnit"
        Me.lueUnit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueUnit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.Appearance.Options.UseBackColor = True
        Me.lueUnit.Properties.Appearance.Options.UseFont = True
        Me.lueUnit.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueUnit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueUnit.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueUnit.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueUnit.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.lueUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueUnit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueUnit.Properties.NullText = "[Isian belum dipilih]"
        Me.lueUnit.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueUnit.Size = New System.Drawing.Size(150, 20)
        Me.lueUnit.TabIndex = 116
        Me.lueUnit.Tag = "idunit"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Unit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueParamedis
        '
        Me.lueParamedis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueParamedis.Location = New System.Drawing.Point(243, 32)
        Me.lueParamedis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueParamedis.Name = "lueParamedis"
        Me.lueParamedis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueParamedis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueParamedis.Properties.Appearance.Options.UseBackColor = True
        Me.lueParamedis.Properties.Appearance.Options.UseFont = True
        Me.lueParamedis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueParamedis.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueParamedis.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueParamedis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueParamedis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueParamedis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueParamedis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueParamedis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueParamedis.Size = New System.Drawing.Size(150, 20)
        Me.lueParamedis.TabIndex = 115
        Me.lueParamedis.Tag = "idparamedis"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Paramedis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsJadwalParamedisSMS
        '
        Me.tsJadwalParamedisSMS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tsJadwalParamedisSMS.Location = New System.Drawing.Point(513, 128)
        Me.tsJadwalParamedisSMS.Margin = New System.Windows.Forms.Padding(0)
        Me.tsJadwalParamedisSMS.Name = "tsJadwalParamedisSMS"
        Me.tsJadwalParamedisSMS.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalParamedisSMS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsJadwalParamedisSMS.Properties.Appearance.Options.UseBackColor = True
        Me.tsJadwalParamedisSMS.Properties.Appearance.Options.UseFont = True
        Me.tsJadwalParamedisSMS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalParamedisSMS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tsJadwalParamedisSMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalParamedisSMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tsJadwalParamedisSMS.Properties.AutoHeight = False
        Me.tsJadwalParamedisSMS.Properties.AutoWidth = True
        Me.tsJadwalParamedisSMS.Properties.OffText = "Tidak"
        Me.tsJadwalParamedisSMS.Properties.OnText = "Ya"
        Me.tsJadwalParamedisSMS.Size = New System.Drawing.Size(106, 20)
        Me.tsJadwalParamedisSMS.TabIndex = 124
        Me.tsJadwalParamedisSMS.Tag = "isparamedissms"
        '
        'Label62
        '
        Me.Label62.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label62.AutoSize = True
        Me.Label62.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label62.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(422, 131)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 14)
        Me.Label62.TabIndex = 116
        Me.Label62.Text = "SMS Paramedis"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label60
        '
        Me.Label60.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label60.AutoSize = True
        Me.Label60.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label60.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(150, 131)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(90, 14)
        Me.Label60.TabIndex = 119
        Me.Label60.Text = "Tanggal Selesai"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deJadwalSelesai
        '
        Me.deJadwalSelesai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deJadwalSelesai.EditValue = Nothing
        Me.deJadwalSelesai.Location = New System.Drawing.Point(243, 128)
        Me.deJadwalSelesai.Margin = New System.Windows.Forms.Padding(0)
        Me.deJadwalSelesai.Name = "deJadwalSelesai"
        Me.deJadwalSelesai.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deJadwalSelesai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalSelesai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deJadwalSelesai.Properties.Appearance.Options.UseBackColor = True
        Me.deJadwalSelesai.Properties.Appearance.Options.UseFont = True
        Me.deJadwalSelesai.Properties.Appearance.Options.UseForeColor = True
        Me.deJadwalSelesai.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalSelesai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deJadwalSelesai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceFocused.Options.UseFont = True
        Me.deJadwalSelesai.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalSelesai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalSelesai.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deJadwalSelesai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deJadwalSelesai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deJadwalSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deJadwalSelesai.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deJadwalSelesai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deJadwalSelesai.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deJadwalSelesai.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deJadwalSelesai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deJadwalSelesai.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deJadwalSelesai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deJadwalSelesai.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deJadwalSelesai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deJadwalSelesai.Size = New System.Drawing.Size(110, 20)
        Me.deJadwalSelesai.TabIndex = 118
        Me.deJadwalSelesai.Tag = "tanggalselesai"
        '
        'deJadwalMulai
        '
        Me.deJadwalMulai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.deJadwalMulai.EditValue = Nothing
        Me.deJadwalMulai.Location = New System.Drawing.Point(243, 104)
        Me.deJadwalMulai.Margin = New System.Windows.Forms.Padding(0)
        Me.deJadwalMulai.Name = "deJadwalMulai"
        Me.deJadwalMulai.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.deJadwalMulai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.deJadwalMulai.Properties.Appearance.Options.UseBackColor = True
        Me.deJadwalMulai.Properties.Appearance.Options.UseFont = True
        Me.deJadwalMulai.Properties.Appearance.Options.UseForeColor = True
        Me.deJadwalMulai.Properties.AppearanceCalendar.DayCellHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceCalendar.DayCellHighlighted.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceCalendar.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceCalendar.Header.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceCalendar.HeaderHighlighted.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceCalendar.WeekNumber.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalMulai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.deJadwalMulai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceDropDown.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceFocused.Options.UseFont = True
        Me.deJadwalMulai.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deJadwalMulai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deJadwalMulai.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.deJadwalMulai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.deJadwalMulai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deJadwalMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deJadwalMulai.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.deJadwalMulai.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deJadwalMulai.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deJadwalMulai.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.deJadwalMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deJadwalMulai.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.deJadwalMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.deJadwalMulai.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.deJadwalMulai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deJadwalMulai.Size = New System.Drawing.Size(110, 20)
        Me.deJadwalMulai.TabIndex = 117
        Me.deJadwalMulai.Tag = "tanggalmulai"
        '
        'Label59
        '
        Me.Label59.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label59.AutoSize = True
        Me.Label59.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label59.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(160, 107)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(80, 14)
        Me.Label59.TabIndex = 118
        Me.Label59.Text = "Tanggal Mulai"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueJadwalSesi
        '
        Me.lueJadwalSesi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJadwalSesi.Location = New System.Drawing.Point(243, 56)
        Me.lueJadwalSesi.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJadwalSesi.Name = "lueJadwalSesi"
        Me.lueJadwalSesi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJadwalSesi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJadwalSesi.Properties.Appearance.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.Appearance.Options.UseFont = True
        Me.lueJadwalSesi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalSesi.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueJadwalSesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJadwalSesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJadwalSesi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJadwalSesi.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJadwalSesi.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJadwalSesi.Size = New System.Drawing.Size(150, 20)
        Me.lueJadwalSesi.TabIndex = 115
        Me.lueJadwalSesi.Tag = "idjadwalsesi"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Sesi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ccboJadwalHari
        '
        Me.ccboJadwalHari.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ccboJadwalHari.Location = New System.Drawing.Point(243, 80)
        Me.ccboJadwalHari.Margin = New System.Windows.Forms.Padding(0)
        Me.ccboJadwalHari.Name = "ccboJadwalHari"
        Me.ccboJadwalHari.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ccboJadwalHari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ccboJadwalHari.Properties.Appearance.Options.UseBackColor = True
        Me.ccboJadwalHari.Properties.Appearance.Options.UseFont = True
        Me.ccboJadwalHari.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ccboJadwalHari.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ccboJadwalHari.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.ccboJadwalHari.Properties.AppearanceDisabled.Options.UseFont = True
        Me.ccboJadwalHari.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ccboJadwalHari.Properties.AppearanceDropDown.Options.UseFont = True
        Me.ccboJadwalHari.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ccboJadwalHari.Properties.AppearanceFocused.Options.UseFont = True
        Me.ccboJadwalHari.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ccboJadwalHari.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.ccboJadwalHari.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.ccboJadwalHari.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.ccboJadwalHari.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ccboJadwalHari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ccboJadwalHari.Size = New System.Drawing.Size(150, 20)
        Me.ccboJadwalHari.TabIndex = 116
        Me.ccboJadwalHari.Tag = "hari"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(213, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 14)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Hari"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJamSelesai
        '
        Me.teJamSelesai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJamSelesai.EditValue = New Date(2015, 8, 4, 0, 0, 0, 0)
        Me.teJamSelesai.Location = New System.Drawing.Point(243, 176)
        Me.teJamSelesai.Margin = New System.Windows.Forms.Padding(0)
        Me.teJamSelesai.Name = "teJamSelesai"
        Me.teJamSelesai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamSelesai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJamSelesai.Properties.Appearance.Options.UseBackColor = True
        Me.teJamSelesai.Properties.Appearance.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamSelesai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teJamSelesai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceFocused.Options.UseFont = True
        Me.teJamSelesai.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamSelesai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamSelesai.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teJamSelesai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teJamSelesai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJamSelesai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teJamSelesai.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.teJamSelesai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamSelesai.Properties.EditFormat.FormatString = "HH:mm"
        Me.teJamSelesai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamSelesai.Properties.Mask.EditMask = "HH:mm"
        Me.teJamSelesai.Size = New System.Drawing.Size(60, 20)
        Me.teJamSelesai.TabIndex = 120
        Me.teJamSelesai.Tag = "jamselesai"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Jam Selesai"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teJamMulai
        '
        Me.teJamMulai.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teJamMulai.EditValue = New Date(2015, 8, 4, 0, 0, 0, 0)
        Me.teJamMulai.Location = New System.Drawing.Point(243, 152)
        Me.teJamMulai.Margin = New System.Windows.Forms.Padding(0)
        Me.teJamMulai.Name = "teJamMulai"
        Me.teJamMulai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamMulai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teJamMulai.Properties.Appearance.Options.UseBackColor = True
        Me.teJamMulai.Properties.Appearance.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamMulai.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.teJamMulai.Properties.AppearanceDisabled.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceFocused.Options.UseFont = True
        Me.teJamMulai.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teJamMulai.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.teJamMulai.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.teJamMulai.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.teJamMulai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teJamMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teJamMulai.Properties.DisplayFormat.FormatString = "HH:mm"
        Me.teJamMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamMulai.Properties.EditFormat.FormatString = "HH:mm"
        Me.teJamMulai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.teJamMulai.Properties.Mask.EditMask = "HH:mm"
        Me.teJamMulai.Size = New System.Drawing.Size(60, 20)
        Me.teJamMulai.TabIndex = 119
        Me.teJamMulai.Tag = "jammulai"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(182, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 14)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Jam Mulai"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(405, 179)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 14)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Tayang di Monitor"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsJadwalMonitor
        '
        Me.tsJadwalMonitor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tsJadwalMonitor.Location = New System.Drawing.Point(513, 176)
        Me.tsJadwalMonitor.Margin = New System.Windows.Forms.Padding(0)
        Me.tsJadwalMonitor.Name = "tsJadwalMonitor"
        Me.tsJadwalMonitor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalMonitor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsJadwalMonitor.Properties.Appearance.Options.UseBackColor = True
        Me.tsJadwalMonitor.Properties.Appearance.Options.UseFont = True
        Me.tsJadwalMonitor.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalMonitor.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tsJadwalMonitor.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalMonitor.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tsJadwalMonitor.Properties.AutoHeight = False
        Me.tsJadwalMonitor.Properties.AutoWidth = True
        Me.tsJadwalMonitor.Properties.OffText = "Tidak"
        Me.tsJadwalMonitor.Properties.OnText = "Ya"
        Me.tsJadwalMonitor.Size = New System.Drawing.Size(106, 20)
        Me.tsJadwalMonitor.TabIndex = 126
        Me.tsJadwalMonitor.Tag = "ismonitor"
        '
        'tsJadwalPasienSMS
        '
        Me.tsJadwalPasienSMS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tsJadwalPasienSMS.Location = New System.Drawing.Point(513, 152)
        Me.tsJadwalPasienSMS.Margin = New System.Windows.Forms.Padding(0)
        Me.tsJadwalPasienSMS.Name = "tsJadwalPasienSMS"
        Me.tsJadwalPasienSMS.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalPasienSMS.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsJadwalPasienSMS.Properties.Appearance.Options.UseBackColor = True
        Me.tsJadwalPasienSMS.Properties.Appearance.Options.UseFont = True
        Me.tsJadwalPasienSMS.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalPasienSMS.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.tsJadwalPasienSMS.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tsJadwalPasienSMS.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.tsJadwalPasienSMS.Properties.AutoHeight = False
        Me.tsJadwalPasienSMS.Properties.AutoWidth = True
        Me.tsJadwalPasienSMS.Properties.OffText = "Tidak"
        Me.tsJadwalPasienSMS.Properties.OnText = "Ya"
        Me.tsJadwalPasienSMS.Size = New System.Drawing.Size(106, 20)
        Me.tsJadwalPasienSMS.TabIndex = 125
        Me.tsJadwalPasienSMS.Tag = "ispasiensms"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(442, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 14)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "SMS Pasien"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seJadwalDurasi
        '
        Me.seJadwalDurasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seJadwalDurasi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seJadwalDurasi.Location = New System.Drawing.Point(513, 104)
        Me.seJadwalDurasi.Margin = New System.Windows.Forms.Padding(0)
        Me.seJadwalDurasi.Name = "seJadwalDurasi"
        Me.seJadwalDurasi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalDurasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seJadwalDurasi.Properties.Appearance.Options.UseBackColor = True
        Me.seJadwalDurasi.Properties.Appearance.Options.UseFont = True
        Me.seJadwalDurasi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalDurasi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.seJadwalDurasi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalDurasi.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.seJadwalDurasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seJadwalDurasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seJadwalDurasi.Properties.DisplayFormat.FormatString = "n0"
        Me.seJadwalDurasi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seJadwalDurasi.Properties.EditFormat.FormatString = "n0"
        Me.seJadwalDurasi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seJadwalDurasi.Properties.IsFloatValue = False
        Me.seJadwalDurasi.Properties.Mask.EditMask = "n0"
        Me.seJadwalDurasi.Properties.MaxLength = 2
        Me.seJadwalDurasi.Properties.MaxValue = New Decimal(New Integer() {150, 0, 0, 0})
        Me.seJadwalDurasi.Size = New System.Drawing.Size(60, 20)
        Me.seJadwalDurasi.TabIndex = 123
        Me.seJadwalDurasi.Tag = "durasi"
        '
        'Label61
        '
        Me.Label61.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label61.AutoSize = True
        Me.Label61.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label61.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(413, 107)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(97, 14)
        Me.Label61.TabIndex = 116
        Me.Label61.Text = "Durasi Pelayanan"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(406, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 14)
        Me.Label16.TabIndex = 115
        Me.Label16.Text = "Max Appointment"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seJadwalMaxApp
        '
        Me.seJadwalMaxApp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seJadwalMaxApp.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seJadwalMaxApp.Location = New System.Drawing.Point(513, 80)
        Me.seJadwalMaxApp.Margin = New System.Windows.Forms.Padding(0)
        Me.seJadwalMaxApp.Name = "seJadwalMaxApp"
        Me.seJadwalMaxApp.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalMaxApp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seJadwalMaxApp.Properties.Appearance.Options.UseBackColor = True
        Me.seJadwalMaxApp.Properties.Appearance.Options.UseFont = True
        Me.seJadwalMaxApp.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalMaxApp.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.seJadwalMaxApp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seJadwalMaxApp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.seJadwalMaxApp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seJadwalMaxApp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seJadwalMaxApp.Properties.DisplayFormat.FormatString = "n0"
        Me.seJadwalMaxApp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seJadwalMaxApp.Properties.EditFormat.FormatString = "n0"
        Me.seJadwalMaxApp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seJadwalMaxApp.Properties.IsFloatValue = False
        Me.seJadwalMaxApp.Properties.Mask.EditMask = "n0"
        Me.seJadwalMaxApp.Properties.MaxLength = 2
        Me.seJadwalMaxApp.Properties.MaxValue = New Decimal(New Integer() {150, 0, 0, 0})
        Me.seJadwalMaxApp.Size = New System.Drawing.Size(60, 20)
        Me.seJadwalMaxApp.TabIndex = 122
        Me.seJadwalMaxApp.Tag = "maxapp"
        '
        'lueJadwalLokasi
        '
        Me.lueJadwalLokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueJadwalLokasi.Location = New System.Drawing.Point(513, 56)
        Me.lueJadwalLokasi.Margin = New System.Windows.Forms.Padding(0)
        Me.lueJadwalLokasi.Name = "lueJadwalLokasi"
        Me.lueJadwalLokasi.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueJadwalLokasi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalLokasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueJadwalLokasi.Properties.Appearance.Options.UseBackColor = True
        Me.lueJadwalLokasi.Properties.Appearance.Options.UseFont = True
        Me.lueJadwalLokasi.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalLokasi.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueJadwalLokasi.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueJadwalLokasi.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueJadwalLokasi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueJadwalLokasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueJadwalLokasi.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueJadwalLokasi.Properties.NullText = "[Isian belum dipilih]"
        Me.lueJadwalLokasi.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueJadwalLokasi.Size = New System.Drawing.Size(150, 20)
        Me.lueJadwalLokasi.TabIndex = 121
        Me.lueJadwalLokasi.Tag = "idlokasi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Ruang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueSpesialis
        '
        Me.lueSpesialis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueSpesialis.Location = New System.Drawing.Point(513, 32)
        Me.lueSpesialis.Margin = New System.Windows.Forms.Padding(0)
        Me.lueSpesialis.Name = "lueSpesialis"
        Me.lueSpesialis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.lueSpesialis.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueSpesialis.Properties.Appearance.Options.UseBackColor = True
        Me.lueSpesialis.Properties.Appearance.Options.UseFont = True
        Me.lueSpesialis.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lueSpesialis.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueSpesialis.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.lueSpesialis.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueSpesialis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSpesialis.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueSpesialis.Properties.NullText = "[Isian belum dipilih]"
        Me.lueSpesialis.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueSpesialis.Size = New System.Drawing.Size(150, 20)
        Me.lueSpesialis.TabIndex = 114
        Me.lueSpesialis.Tag = "idparamedisspesialis"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(460, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 14)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "Spesialis"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnExport)
        Me.pHeader.Controls.Add(Me.btnNew)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Controls.Add(Me.btnDeletePermanen)
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
        Me.btnExport.Location = New System.Drawing.Point(346, 0)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 30)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(446, 0)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(60, 30)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "BARU"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(506, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SIMPAN"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(586, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'btnDeletePermanen
        '
        Me.btnDeletePermanen.BackColor = System.Drawing.Color.Maroon
        Me.btnDeletePermanen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeletePermanen.FlatAppearance.BorderSize = 0
        Me.btnDeletePermanen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnDeletePermanen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDeletePermanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePermanen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePermanen.Location = New System.Drawing.Point(666, 0)
        Me.btnDeletePermanen.Name = "btnDeletePermanen"
        Me.btnDeletePermanen.Size = New System.Drawing.Size(120, 30)
        Me.btnDeletePermanen.TabIndex = 19
        Me.btnDeletePermanen.Text = "HAPUS PERMANEN"
        Me.btnDeletePermanen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletePermanen.UseVisualStyleBackColor = False
        '
        'frmParamedisJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmParamedisJadwal"
        Me.ShowInTaskbar = False
        Me.Text = "Jadwal Dokter"
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        Me.pBody.PerformLayout()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rimeJadwalRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal2.ResumeLayout(False)
        Me.tlpJadwal2.PerformLayout()
        CType(Me.meJadwalRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpJadwal1.ResumeLayout(False)
        Me.tlpJadwal1.PerformLayout()
        CType(Me.lueUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueParamedis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsJadwalParamedisSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deJadwalSelesai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deJadwalSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deJadwalMulai.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deJadwalMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJadwalSesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccboJadwalHari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJamSelesai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teJamMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsJadwalMonitor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tsJadwalPasienSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seJadwalDurasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seJadwalMaxApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueJadwalLokasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSpesialis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents tlpJadwal2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents meJadwalRemarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tlpJadwal1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lueParamedis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsJadwalParamedisSMS As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents deJadwalSelesai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deJadwalMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents lueJadwalSesi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ccboJadwalHari As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents teJamSelesai As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents teJamMulai As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tsJadwalMonitor As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents tsJadwalPasienSMS As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents seJadwalDurasi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents seJadwalMaxApp As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lueJadwalLokasi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lueSpesialis As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn136 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn99 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn130 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn101 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn103 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn114 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn115 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn116 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn117 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn118 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn119 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn98 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn120 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn121 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn122 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn123 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn124 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn125 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn126 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn127 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rimeJadwalRemarks As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueUnit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDeletePermanen As Button
End Class
