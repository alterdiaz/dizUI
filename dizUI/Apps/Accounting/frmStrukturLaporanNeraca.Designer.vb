<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStrukturLaporanNeraca
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gvDetil = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gdtID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtIDparent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtFaktorArusKas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtFaktor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtStatusData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtIsTurunan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gdtTurunan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIDStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUrutan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pMinimize = New System.Windows.Forms.PictureBox()
        Me.pMaximize = New System.Windows.Forms.PictureBox()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcStruktur = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpEntryS = New DevExpress.XtraTab.XtraTabPage()
        Me.pEntryS = New System.Windows.Forms.Panel()
        Me.gcStruktur = New DevExpress.XtraGrid.GridControl()
        Me.gvStruktur = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcsID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsIDStat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsNomorUrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsStrukturArusKas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcsStatusData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpStruktur = New System.Windows.Forms.TableLayoutPanel()
        Me.lueInputSPeriode = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.seUrutan = New DevExpress.XtraEditors.SpinEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.teStruktur = New DevExpress.XtraEditors.TextEdit()
        Me.lblStruktur = New System.Windows.Forms.Label()
        Me.xtpPeriode = New DevExpress.XtraTab.XtraTabPage()
        Me.gcPeriode = New DevExpress.XtraGrid.GridControl()
        Me.gvPeriode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpPeriode = New System.Windows.Forms.TableLayoutPanel()
        Me.tePeriodeStrukturTahun = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tePeriodeRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xtpEntryR = New DevExpress.XtraTab.XtraTabPage()
        Me.pEntryR = New System.Windows.Forms.Panel()
        Me.gcRekening = New DevExpress.XtraGrid.GridControl()
        Me.gvRekening = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcrID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrIDparent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrIDCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrKodeRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrRekening = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrFaktor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrFaktorArusKas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrStatusData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrStatData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrIsTurunan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcrTurunan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tlpRekening = New System.Windows.Forms.TableLayoutPanel()
        Me.lueStruktur = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lueKodeRekening = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lueRekening = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lueFaktor = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueRTurunan = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.xtpStruktur = New DevExpress.XtraTab.XtraTabPage()
        Me.pStruktur = New System.Windows.Forms.Panel()
        Me.tlpData = New System.Windows.Forms.TableLayoutPanel()
        Me.lueStrukturPeriode = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.btnPeriode = New System.Windows.Forms.Button()
        Me.btnRekening = New System.Windows.Forms.Button()
        Me.btnStruktur = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSep5 = New System.Windows.Forms.Label()
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpForm.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pBody.SuspendLayout()
        CType(Me.xtcStruktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcStruktur.SuspendLayout()
        Me.xtpEntryS.SuspendLayout()
        Me.pEntryS.SuspendLayout()
        CType(Me.gcStruktur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvStruktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpStruktur.SuspendLayout()
        CType(Me.lueInputSPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seUrutan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teStruktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpPeriode.SuspendLayout()
        CType(Me.gcPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPeriode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpPeriode.SuspendLayout()
        CType(Me.tePeriodeStrukturTahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePeriodeRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpEntryR.SuspendLayout()
        Me.pEntryR.SuspendLayout()
        CType(Me.gcRekening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRekening, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpRekening.SuspendLayout()
        CType(Me.lueStruktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueKodeRekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRekening.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueFaktor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueRTurunan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpStruktur.SuspendLayout()
        Me.pStruktur.SuspendLayout()
        Me.tlpData.SuspendLayout()
        CType(Me.lueStrukturPeriode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvDetil
        '
        Me.gvDetil.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvDetil.Appearance.Empty.Options.UseBackColor = True
        Me.gvDetil.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetil.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvDetil.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvDetil.Appearance.OddRow.Options.UseBackColor = True
        Me.gvDetil.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gdtID, Me.gdtIDparent, Me.gdtIDCOA, Me.gdtCOA, Me.gdtRekening, Me.gdtFaktorArusKas, Me.gdtFaktor, Me.gdtStatusData, Me.gdtStatData, Me.gdtIsTurunan, Me.gdtTurunan})
        Me.gvDetil.GridControl = Me.gcData
        Me.gvDetil.Name = "gvDetil"
        Me.gvDetil.OptionsDetail.AllowZoomDetail = False
        Me.gvDetil.OptionsDetail.ShowDetailTabs = False
        Me.gvDetil.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvDetil.OptionsView.EnableAppearanceEvenRow = True
        Me.gvDetil.OptionsView.EnableAppearanceOddRow = True
        Me.gvDetil.OptionsView.ShowDetailButtons = False
        Me.gvDetil.OptionsView.ShowGroupPanel = False
        '
        'gdtID
        '
        Me.gdtID.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtID.Caption = "ID"
        Me.gdtID.FieldName = "idstrukturlaporanneracadt"
        Me.gdtID.Name = "gdtID"
        Me.gdtID.OptionsColumn.AllowEdit = False
        Me.gdtID.OptionsColumn.ReadOnly = True
        '
        'gdtIDparent
        '
        Me.gdtIDparent.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtIDparent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtIDparent.Caption = "ID"
        Me.gdtIDparent.FieldName = "idstrukturlaporanneraca"
        Me.gdtIDparent.Name = "gdtIDparent"
        Me.gdtIDparent.OptionsColumn.AllowEdit = False
        Me.gdtIDparent.OptionsColumn.ReadOnly = True
        '
        'gdtIDCOA
        '
        Me.gdtIDCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtIDCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtIDCOA.Caption = "IDCOA"
        Me.gdtIDCOA.FieldName = "idcoa"
        Me.gdtIDCOA.Name = "gdtIDCOA"
        Me.gdtIDCOA.OptionsColumn.AllowEdit = False
        Me.gdtIDCOA.OptionsColumn.ReadOnly = True
        '
        'gdtCOA
        '
        Me.gdtCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtCOA.Caption = "Kode Rekening"
        Me.gdtCOA.FieldName = "coa"
        Me.gdtCOA.Name = "gdtCOA"
        Me.gdtCOA.OptionsColumn.AllowEdit = False
        Me.gdtCOA.OptionsColumn.ReadOnly = True
        Me.gdtCOA.Visible = True
        Me.gdtCOA.VisibleIndex = 0
        '
        'gdtRekening
        '
        Me.gdtRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtRekening.Caption = "Rekening"
        Me.gdtRekening.FieldName = "remarks"
        Me.gdtRekening.Name = "gdtRekening"
        Me.gdtRekening.OptionsColumn.AllowEdit = False
        Me.gdtRekening.OptionsColumn.ReadOnly = True
        Me.gdtRekening.Visible = True
        Me.gdtRekening.VisibleIndex = 1
        '
        'gdtFaktorArusKas
        '
        Me.gdtFaktorArusKas.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtFaktorArusKas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtFaktorArusKas.Caption = "Faktor Arus Kas"
        Me.gdtFaktorArusKas.FieldName = "faktoraruskas"
        Me.gdtFaktorArusKas.Name = "gdtFaktorArusKas"
        Me.gdtFaktorArusKas.OptionsColumn.AllowEdit = False
        Me.gdtFaktorArusKas.OptionsColumn.ReadOnly = True
        '
        'gdtFaktor
        '
        Me.gdtFaktor.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtFaktor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtFaktor.Caption = "Faktor Lap. Neraca"
        Me.gdtFaktor.FieldName = "faktor"
        Me.gdtFaktor.Name = "gdtFaktor"
        Me.gdtFaktor.OptionsColumn.AllowEdit = False
        Me.gdtFaktor.OptionsColumn.ReadOnly = True
        Me.gdtFaktor.Visible = True
        Me.gdtFaktor.VisibleIndex = 2
        '
        'gdtStatusData
        '
        Me.gdtStatusData.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtStatusData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtStatusData.Caption = "Status Data"
        Me.gdtStatusData.FieldName = "statusdata"
        Me.gdtStatusData.Name = "gdtStatusData"
        Me.gdtStatusData.OptionsColumn.AllowEdit = False
        Me.gdtStatusData.OptionsColumn.ReadOnly = True
        '
        'gdtStatData
        '
        Me.gdtStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtStatData.Caption = "Status Data"
        Me.gdtStatData.FieldName = "statdata"
        Me.gdtStatData.Name = "gdtStatData"
        Me.gdtStatData.OptionsColumn.AllowEdit = False
        Me.gdtStatData.OptionsColumn.ReadOnly = True
        Me.gdtStatData.Visible = True
        Me.gdtStatData.VisibleIndex = 4
        '
        'gdtIsTurunan
        '
        Me.gdtIsTurunan.Caption = "IsTurunan"
        Me.gdtIsTurunan.FieldName = "isturunan"
        Me.gdtIsTurunan.Name = "gdtIsTurunan"
        '
        'gdtTurunan
        '
        Me.gdtTurunan.AppearanceHeader.Options.UseTextOptions = True
        Me.gdtTurunan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gdtTurunan.Caption = "Turunan"
        Me.gdtTurunan.FieldName = "turunan"
        Me.gdtTurunan.Name = "gdtTurunan"
        Me.gdtTurunan.OptionsColumn.AllowEdit = False
        Me.gdtTurunan.OptionsColumn.ReadOnly = True
        Me.gdtTurunan.Visible = True
        Me.gdtTurunan.VisibleIndex = 3
        '
        'gcData
        '
        Me.gcData.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvDetil
        GridLevelNode1.RelationName = "Detil"
        Me.gcData.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcData.Location = New System.Drawing.Point(0, 36)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(706, 306)
        Me.gcData.TabIndex = 8
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData, Me.gvDetil})
        '
        'gvData
        '
        Me.gvData.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvData.Appearance.Empty.Options.UseBackColor = True
        Me.gvData.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvData.Appearance.OddRow.Options.UseBackColor = True
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcID, Me.gcIDStatData, Me.gcUrutan, Me.gcSK, Me.gcStatData})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        Me.gvData.OptionsDetail.AllowZoomDetail = False
        Me.gvData.OptionsDetail.ShowDetailTabs = False
        Me.gvData.OptionsView.EnableAppearanceEvenRow = True
        Me.gvData.OptionsView.EnableAppearanceOddRow = True
        Me.gvData.OptionsView.ShowGroupPanel = False
        '
        'gcID
        '
        Me.gcID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcID.Caption = "ID"
        Me.gcID.FieldName = "idstrukturlaporanneraca"
        Me.gcID.Name = "gcID"
        Me.gcID.OptionsColumn.AllowEdit = False
        Me.gcID.OptionsColumn.ReadOnly = True
        '
        'gcIDStatData
        '
        Me.gcIDStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcIDStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcIDStatData.Caption = "ID Status Data"
        Me.gcIDStatData.FieldName = "statusdata"
        Me.gcIDStatData.Name = "gcIDStatData"
        Me.gcIDStatData.OptionsColumn.AllowEdit = False
        Me.gcIDStatData.OptionsColumn.ReadOnly = True
        '
        'gcUrutan
        '
        Me.gcUrutan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcUrutan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcUrutan.Caption = "No Urut"
        Me.gcUrutan.FieldName = "nomorurut"
        Me.gcUrutan.Name = "gcUrutan"
        Me.gcUrutan.OptionsColumn.AllowEdit = False
        Me.gcUrutan.OptionsColumn.ReadOnly = True
        Me.gcUrutan.Visible = True
        Me.gcUrutan.VisibleIndex = 0
        '
        'gcSK
        '
        Me.gcSK.AppearanceHeader.Options.UseTextOptions = True
        Me.gcSK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcSK.Caption = "Struktur Lap. Neraca"
        Me.gcSK.FieldName = "strukturlaporanneraca"
        Me.gcSK.Name = "gcSK"
        Me.gcSK.OptionsColumn.AllowEdit = False
        Me.gcSK.OptionsColumn.ReadOnly = True
        Me.gcSK.Visible = True
        Me.gcSK.VisibleIndex = 1
        '
        'gcStatData
        '
        Me.gcStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcStatData.Caption = "Status Data"
        Me.gcStatData.FieldName = "statdata"
        Me.gcStatData.Name = "gcStatData"
        Me.gcStatData.OptionsColumn.AllowEdit = False
        Me.gcStatData.OptionsColumn.ReadOnly = True
        Me.gcStatData.Visible = True
        Me.gcStatData.VisibleIndex = 2
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
        Me.lblTitle.Text = "Struktur Laporan Neraca"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.UseMnemonic = False
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
        Me.pBody.Controls.Add(Me.xtcStruktur)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(786, 378)
        Me.pBody.TabIndex = 7
        '
        'xtcStruktur
        '
        Me.xtcStruktur.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcStruktur.Appearance.Options.UseBackColor = True
        Me.xtcStruktur.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcStruktur.AppearancePage.Header.Options.UseFont = True
        Me.xtcStruktur.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcStruktur.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcStruktur.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcStruktur.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcStruktur.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcStruktur.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcStruktur.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcStruktur.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcStruktur.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcStruktur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcStruktur.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcStruktur.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right
        Me.xtcStruktur.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcStruktur.Location = New System.Drawing.Point(0, 30)
        Me.xtcStruktur.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcStruktur.Name = "xtcStruktur"
        Me.xtcStruktur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcStruktur.SelectedTabPage = Me.xtpEntryS
        Me.xtcStruktur.Size = New System.Drawing.Size(786, 348)
        Me.xtcStruktur.TabIndex = 18
        Me.xtcStruktur.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPeriode, Me.xtpEntryS, Me.xtpEntryR, Me.xtpStruktur})
        '
        'xtpEntryS
        '
        Me.xtpEntryS.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpEntryS.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpEntryS.Controls.Add(Me.pEntryS)
        Me.xtpEntryS.Name = "xtpEntryS"
        Me.xtpEntryS.Size = New System.Drawing.Size(706, 342)
        Me.xtpEntryS.Text = "INPUT S"
        '
        'pEntryS
        '
        Me.pEntryS.AutoScroll = True
        Me.pEntryS.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pEntryS.Controls.Add(Me.gcStruktur)
        Me.pEntryS.Controls.Add(Me.tlpStruktur)
        Me.pEntryS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEntryS.Location = New System.Drawing.Point(0, 0)
        Me.pEntryS.Name = "pEntryS"
        Me.pEntryS.Size = New System.Drawing.Size(706, 342)
        Me.pEntryS.TabIndex = 0
        '
        'gcStruktur
        '
        Me.gcStruktur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcStruktur.Location = New System.Drawing.Point(0, 84)
        Me.gcStruktur.MainView = Me.gvStruktur
        Me.gcStruktur.Name = "gcStruktur"
        Me.gcStruktur.Size = New System.Drawing.Size(706, 258)
        Me.gcStruktur.TabIndex = 9
        Me.gcStruktur.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvStruktur})
        '
        'gvStruktur
        '
        Me.gvStruktur.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvStruktur.Appearance.Empty.Options.UseBackColor = True
        Me.gvStruktur.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvStruktur.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvStruktur.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvStruktur.Appearance.OddRow.Options.UseBackColor = True
        Me.gvStruktur.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcsID, Me.gcsIDStat, Me.GridColumn7, Me.GridColumn8, Me.gcsNomorUrut, Me.gcsStrukturArusKas, Me.gcsStatusData})
        Me.gvStruktur.GridControl = Me.gcStruktur
        Me.gvStruktur.Name = "gvStruktur"
        Me.gvStruktur.OptionsDetail.ShowDetailTabs = False
        Me.gvStruktur.OptionsView.EnableAppearanceEvenRow = True
        Me.gvStruktur.OptionsView.EnableAppearanceOddRow = True
        Me.gvStruktur.OptionsView.ShowGroupPanel = False
        '
        'gcsID
        '
        Me.gcsID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcsID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcsID.Caption = "ID"
        Me.gcsID.FieldName = "idstrukturlaporanneraca"
        Me.gcsID.Name = "gcsID"
        Me.gcsID.OptionsColumn.AllowEdit = False
        Me.gcsID.OptionsColumn.ReadOnly = True
        '
        'gcsIDStat
        '
        Me.gcsIDStat.AppearanceHeader.Options.UseTextOptions = True
        Me.gcsIDStat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcsIDStat.Caption = "ID Status Data"
        Me.gcsIDStat.FieldName = "statusdata"
        Me.gcsIDStat.Name = "gcsIDStat"
        Me.gcsIDStat.OptionsColumn.AllowEdit = False
        Me.gcsIDStat.OptionsColumn.ReadOnly = True
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.FieldName = "idstrukturlaporanneracatahun"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "No. Lap. Neraca"
        Me.GridColumn8.FieldName = "strukturlaporanneracatahun"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 112
        '
        'gcsNomorUrut
        '
        Me.gcsNomorUrut.AppearanceHeader.Options.UseTextOptions = True
        Me.gcsNomorUrut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcsNomorUrut.Caption = "No Urut"
        Me.gcsNomorUrut.FieldName = "nomorurut"
        Me.gcsNomorUrut.Name = "gcsNomorUrut"
        Me.gcsNomorUrut.OptionsColumn.AllowEdit = False
        Me.gcsNomorUrut.OptionsColumn.ReadOnly = True
        Me.gcsNomorUrut.Visible = True
        Me.gcsNomorUrut.VisibleIndex = 1
        Me.gcsNomorUrut.Width = 61
        '
        'gcsStrukturArusKas
        '
        Me.gcsStrukturArusKas.AppearanceHeader.Options.UseTextOptions = True
        Me.gcsStrukturArusKas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcsStrukturArusKas.Caption = "Struktur Lap. Neraca"
        Me.gcsStrukturArusKas.FieldName = "strukturlaporanneraca"
        Me.gcsStrukturArusKas.Name = "gcsStrukturArusKas"
        Me.gcsStrukturArusKas.OptionsColumn.AllowEdit = False
        Me.gcsStrukturArusKas.OptionsColumn.ReadOnly = True
        Me.gcsStrukturArusKas.Visible = True
        Me.gcsStrukturArusKas.VisibleIndex = 2
        Me.gcsStrukturArusKas.Width = 397
        '
        'gcsStatusData
        '
        Me.gcsStatusData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcsStatusData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcsStatusData.Caption = "Status Data"
        Me.gcsStatusData.FieldName = "statdata"
        Me.gcsStatusData.Name = "gcsStatusData"
        Me.gcsStatusData.OptionsColumn.AllowEdit = False
        Me.gcsStatusData.OptionsColumn.ReadOnly = True
        Me.gcsStatusData.Visible = True
        Me.gcsStatusData.VisibleIndex = 3
        Me.gcsStatusData.Width = 118
        '
        'tlpStruktur
        '
        Me.tlpStruktur.AutoSize = True
        Me.tlpStruktur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpStruktur.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpStruktur.ColumnCount = 4
        Me.tlpStruktur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpStruktur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpStruktur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440.0!))
        Me.tlpStruktur.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpStruktur.Controls.Add(Me.lueInputSPeriode, 2, 1)
        Me.tlpStruktur.Controls.Add(Me.Label7, 1, 1)
        Me.tlpStruktur.Controls.Add(Me.seUrutan, 2, 2)
        Me.tlpStruktur.Controls.Add(Me.Label5, 1, 2)
        Me.tlpStruktur.Controls.Add(Me.teStruktur, 2, 3)
        Me.tlpStruktur.Controls.Add(Me.lblStruktur, 1, 3)
        Me.tlpStruktur.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpStruktur.Location = New System.Drawing.Point(0, 0)
        Me.tlpStruktur.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpStruktur.Name = "tlpStruktur"
        Me.tlpStruktur.RowCount = 5
        Me.tlpStruktur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpStruktur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpStruktur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpStruktur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpStruktur.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpStruktur.Size = New System.Drawing.Size(706, 84)
        Me.tlpStruktur.TabIndex = 7
        '
        'lueInputSPeriode
        '
        Me.lueInputSPeriode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueInputSPeriode.Location = New System.Drawing.Point(203, 8)
        Me.lueInputSPeriode.Margin = New System.Windows.Forms.Padding(0)
        Me.lueInputSPeriode.Name = "lueInputSPeriode"
        Me.lueInputSPeriode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueInputSPeriode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueInputSPeriode.Properties.Appearance.Options.UseBackColor = True
        Me.lueInputSPeriode.Properties.Appearance.Options.UseFont = True
        Me.lueInputSPeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueInputSPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueInputSPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueInputSPeriode.Properties.NullText = "[Isian belum dipilih]"
        Me.lueInputSPeriode.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueInputSPeriode.Size = New System.Drawing.Size(172, 20)
        Me.lueInputSPeriode.TabIndex = 31
        Me.lueInputSPeriode.Tag = "idstrukturlaporanneraca"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "No. Lap. Neraca"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seUrutan
        '
        Me.seUrutan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.seUrutan.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seUrutan.Location = New System.Drawing.Point(203, 32)
        Me.seUrutan.Margin = New System.Windows.Forms.Padding(0)
        Me.seUrutan.Name = "seUrutan"
        Me.seUrutan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.seUrutan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.seUrutan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seUrutan.Properties.Appearance.Options.UseBackColor = True
        Me.seUrutan.Properties.Appearance.Options.UseFont = True
        Me.seUrutan.Properties.Appearance.Options.UseTextOptions = True
        Me.seUrutan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.seUrutan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.seUrutan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.seUrutan.Properties.DisplayFormat.FormatString = "d"
        Me.seUrutan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seUrutan.Properties.EditFormat.FormatString = "d"
        Me.seUrutan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seUrutan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.seUrutan.Properties.IsFloatValue = False
        Me.seUrutan.Properties.Mask.EditMask = "d"
        Me.seUrutan.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seUrutan.Properties.MaxValue = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.seUrutan.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seUrutan.Size = New System.Drawing.Size(81, 20)
        Me.seUrutan.TabIndex = 41
        Me.seUrutan.Tag = "nomorurut"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nomor Urut di Laporan"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'teStruktur
        '
        Me.teStruktur.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.teStruktur.Location = New System.Drawing.Point(203, 56)
        Me.teStruktur.Margin = New System.Windows.Forms.Padding(0)
        Me.teStruktur.Name = "teStruktur"
        Me.teStruktur.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.teStruktur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.teStruktur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.teStruktur.Properties.Appearance.Options.UseBackColor = True
        Me.teStruktur.Properties.Appearance.Options.UseFont = True
        Me.teStruktur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.teStruktur.Properties.MaxLength = 100
        Me.teStruktur.Properties.NullText = "[Belum Diisi]"
        Me.teStruktur.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.teStruktur.Size = New System.Drawing.Size(440, 20)
        Me.teStruktur.TabIndex = 18
        Me.teStruktur.Tag = "strukturlaporanneraca"
        '
        'lblStruktur
        '
        Me.lblStruktur.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblStruktur.AutoSize = True
        Me.lblStruktur.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStruktur.Location = New System.Drawing.Point(80, 59)
        Me.lblStruktur.Name = "lblStruktur"
        Me.lblStruktur.Size = New System.Drawing.Size(120, 14)
        Me.lblStruktur.TabIndex = 20
        Me.lblStruktur.Text = "Struktur Lap. Neraca"
        Me.lblStruktur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtpPeriode
        '
        Me.xtpPeriode.Controls.Add(Me.gcPeriode)
        Me.xtpPeriode.Controls.Add(Me.tlpPeriode)
        Me.xtpPeriode.Name = "xtpPeriode"
        Me.xtpPeriode.Size = New System.Drawing.Size(706, 342)
        Me.xtpPeriode.Text = "PERIODE"
        '
        'gcPeriode
        '
        Me.gcPeriode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPeriode.Location = New System.Drawing.Point(0, 60)
        Me.gcPeriode.MainView = Me.gvPeriode
        Me.gcPeriode.Name = "gcPeriode"
        Me.gcPeriode.Size = New System.Drawing.Size(706, 282)
        Me.gcPeriode.TabIndex = 10
        Me.gcPeriode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPeriode})
        '
        'gvPeriode
        '
        Me.gvPeriode.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvPeriode.Appearance.Empty.Options.UseBackColor = True
        Me.gvPeriode.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvPeriode.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvPeriode.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvPeriode.Appearance.OddRow.Options.UseBackColor = True
        Me.gvPeriode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn4, Me.GridColumn6})
        Me.gvPeriode.GridControl = Me.gcPeriode
        Me.gvPeriode.Name = "gvPeriode"
        Me.gvPeriode.OptionsDetail.ShowDetailTabs = False
        Me.gvPeriode.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPeriode.OptionsView.EnableAppearanceOddRow = True
        Me.gvPeriode.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "ID"
        Me.GridColumn2.FieldName = "idstrukturlaporanneracatahun"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "ID Status Data"
        Me.GridColumn3.FieldName = "statusdata"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "No. Lap. Neraca"
        Me.GridColumn5.FieldName = "strukturlaporanneracatahun"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 201
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Keterangan"
        Me.GridColumn4.FieldName = "remarks"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 340
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Status Data"
        Me.GridColumn6.FieldName = "statdata"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 147
        '
        'tlpPeriode
        '
        Me.tlpPeriode.AutoSize = True
        Me.tlpPeriode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpPeriode.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpPeriode.ColumnCount = 4
        Me.tlpPeriode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPeriode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpPeriode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440.0!))
        Me.tlpPeriode.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpPeriode.Controls.Add(Me.tePeriodeStrukturTahun, 2, 1)
        Me.tlpPeriode.Controls.Add(Me.Label9, 1, 1)
        Me.tlpPeriode.Controls.Add(Me.tePeriodeRemarks, 2, 2)
        Me.tlpPeriode.Controls.Add(Me.Label10, 1, 2)
        Me.tlpPeriode.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpPeriode.Location = New System.Drawing.Point(0, 0)
        Me.tlpPeriode.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpPeriode.Name = "tlpPeriode"
        Me.tlpPeriode.RowCount = 4
        Me.tlpPeriode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPeriode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPeriode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpPeriode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpPeriode.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpPeriode.Size = New System.Drawing.Size(706, 60)
        Me.tlpPeriode.TabIndex = 8
        '
        'tePeriodeStrukturTahun
        '
        Me.tePeriodeStrukturTahun.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePeriodeStrukturTahun.Location = New System.Drawing.Point(203, 8)
        Me.tePeriodeStrukturTahun.Margin = New System.Windows.Forms.Padding(0)
        Me.tePeriodeStrukturTahun.Name = "tePeriodeStrukturTahun"
        Me.tePeriodeStrukturTahun.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePeriodeStrukturTahun.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePeriodeStrukturTahun.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePeriodeStrukturTahun.Properties.Appearance.Options.UseBackColor = True
        Me.tePeriodeStrukturTahun.Properties.Appearance.Options.UseFont = True
        Me.tePeriodeStrukturTahun.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePeriodeStrukturTahun.Properties.MaxLength = 100
        Me.tePeriodeStrukturTahun.Properties.NullText = "[Belum Diisi]"
        Me.tePeriodeStrukturTahun.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePeriodeStrukturTahun.Size = New System.Drawing.Size(281, 20)
        Me.tePeriodeStrukturTahun.TabIndex = 19
        Me.tePeriodeStrukturTahun.Tag = "strukturlaporanneracatahun"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 14)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No. Lap. Neraca"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tePeriodeRemarks
        '
        Me.tePeriodeRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tePeriodeRemarks.Location = New System.Drawing.Point(203, 32)
        Me.tePeriodeRemarks.Margin = New System.Windows.Forms.Padding(0)
        Me.tePeriodeRemarks.Name = "tePeriodeRemarks"
        Me.tePeriodeRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.tePeriodeRemarks.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tePeriodeRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tePeriodeRemarks.Properties.Appearance.Options.UseBackColor = True
        Me.tePeriodeRemarks.Properties.Appearance.Options.UseFont = True
        Me.tePeriodeRemarks.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tePeriodeRemarks.Properties.MaxLength = 100
        Me.tePeriodeRemarks.Properties.NullText = "[Belum Diisi]"
        Me.tePeriodeRemarks.Properties.NullValuePrompt = "[Belum Diisi]"
        Me.tePeriodeRemarks.Size = New System.Drawing.Size(440, 20)
        Me.tePeriodeRemarks.TabIndex = 18
        Me.tePeriodeRemarks.Tag = "remarks"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(130, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Keterangan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtpEntryR
        '
        Me.xtpEntryR.Controls.Add(Me.pEntryR)
        Me.xtpEntryR.Name = "xtpEntryR"
        Me.xtpEntryR.Size = New System.Drawing.Size(706, 342)
        Me.xtpEntryR.Text = "INPUT R"
        '
        'pEntryR
        '
        Me.pEntryR.AutoScroll = True
        Me.pEntryR.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pEntryR.Controls.Add(Me.gcRekening)
        Me.pEntryR.Controls.Add(Me.tlpRekening)
        Me.pEntryR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEntryR.Location = New System.Drawing.Point(0, 0)
        Me.pEntryR.Name = "pEntryR"
        Me.pEntryR.Size = New System.Drawing.Size(706, 342)
        Me.pEntryR.TabIndex = 1
        '
        'gcRekening
        '
        Me.gcRekening.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcRekening.Location = New System.Drawing.Point(0, 132)
        Me.gcRekening.MainView = Me.gvRekening
        Me.gcRekening.Name = "gcRekening"
        Me.gcRekening.Size = New System.Drawing.Size(706, 210)
        Me.gcRekening.TabIndex = 10
        Me.gcRekening.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRekening})
        '
        'gvRekening
        '
        Me.gvRekening.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvRekening.Appearance.Empty.Options.UseBackColor = True
        Me.gvRekening.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvRekening.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvRekening.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvRekening.Appearance.OddRow.Options.UseBackColor = True
        Me.gvRekening.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcrID, Me.gcrIDparent, Me.gcrIDCOA, Me.GridColumn1, Me.gcrKodeRekening, Me.gcrRekening, Me.gcrFaktor, Me.gcrFaktorArusKas, Me.gcrStatusData, Me.gcrStatData, Me.gcrIsTurunan, Me.gcrTurunan})
        Me.gvRekening.GridControl = Me.gcRekening
        Me.gvRekening.Name = "gvRekening"
        Me.gvRekening.OptionsDetail.ShowDetailTabs = False
        Me.gvRekening.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.gvRekening.OptionsView.EnableAppearanceEvenRow = True
        Me.gvRekening.OptionsView.EnableAppearanceOddRow = True
        Me.gvRekening.OptionsView.ShowDetailButtons = False
        Me.gvRekening.OptionsView.ShowGroupPanel = False
        '
        'gcrID
        '
        Me.gcrID.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrID.Caption = "ID"
        Me.gcrID.FieldName = "idstrukturlaporanneracadt"
        Me.gcrID.Name = "gcrID"
        Me.gcrID.OptionsColumn.AllowEdit = False
        Me.gcrID.OptionsColumn.ReadOnly = True
        '
        'gcrIDparent
        '
        Me.gcrIDparent.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrIDparent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrIDparent.Caption = "ID"
        Me.gcrIDparent.FieldName = "idstrukturlaporanneraca"
        Me.gcrIDparent.Name = "gcrIDparent"
        Me.gcrIDparent.OptionsColumn.AllowEdit = False
        Me.gcrIDparent.OptionsColumn.ReadOnly = True
        '
        'gcrIDCOA
        '
        Me.gcrIDCOA.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrIDCOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrIDCOA.Caption = "IDCOA"
        Me.gcrIDCOA.FieldName = "idcoa"
        Me.gcrIDCOA.Name = "gcrIDCOA"
        Me.gcrIDCOA.OptionsColumn.AllowEdit = False
        Me.gcrIDCOA.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Induk"
        Me.GridColumn1.FieldName = "strukturlaporanneraca"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'gcrKodeRekening
        '
        Me.gcrKodeRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrKodeRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrKodeRekening.Caption = "Kode Rekening"
        Me.gcrKodeRekening.FieldName = "coa"
        Me.gcrKodeRekening.Name = "gcrKodeRekening"
        Me.gcrKodeRekening.OptionsColumn.AllowEdit = False
        Me.gcrKodeRekening.OptionsColumn.ReadOnly = True
        Me.gcrKodeRekening.Visible = True
        Me.gcrKodeRekening.VisibleIndex = 1
        '
        'gcrRekening
        '
        Me.gcrRekening.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrRekening.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrRekening.Caption = "Rekening"
        Me.gcrRekening.FieldName = "remarks"
        Me.gcrRekening.Name = "gcrRekening"
        Me.gcrRekening.OptionsColumn.AllowEdit = False
        Me.gcrRekening.OptionsColumn.ReadOnly = True
        Me.gcrRekening.Visible = True
        Me.gcrRekening.VisibleIndex = 2
        '
        'gcrFaktor
        '
        Me.gcrFaktor.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrFaktor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrFaktor.Caption = "Faktor Arus Kas"
        Me.gcrFaktor.FieldName = "faktoraruskas"
        Me.gcrFaktor.Name = "gcrFaktor"
        Me.gcrFaktor.OptionsColumn.AllowEdit = False
        Me.gcrFaktor.OptionsColumn.ReadOnly = True
        '
        'gcrFaktorArusKas
        '
        Me.gcrFaktorArusKas.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrFaktorArusKas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrFaktorArusKas.Caption = "Faktor Lap. Neraca"
        Me.gcrFaktorArusKas.FieldName = "faktor"
        Me.gcrFaktorArusKas.Name = "gcrFaktorArusKas"
        Me.gcrFaktorArusKas.OptionsColumn.AllowEdit = False
        Me.gcrFaktorArusKas.OptionsColumn.ReadOnly = True
        Me.gcrFaktorArusKas.Visible = True
        Me.gcrFaktorArusKas.VisibleIndex = 3
        '
        'gcrStatusData
        '
        Me.gcrStatusData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrStatusData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrStatusData.Caption = "Status Data"
        Me.gcrStatusData.FieldName = "statusdata"
        Me.gcrStatusData.Name = "gcrStatusData"
        Me.gcrStatusData.OptionsColumn.AllowEdit = False
        Me.gcrStatusData.OptionsColumn.ReadOnly = True
        '
        'gcrStatData
        '
        Me.gcrStatData.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrStatData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrStatData.Caption = "Status Data"
        Me.gcrStatData.FieldName = "statdata"
        Me.gcrStatData.Name = "gcrStatData"
        Me.gcrStatData.OptionsColumn.AllowEdit = False
        Me.gcrStatData.OptionsColumn.ReadOnly = True
        Me.gcrStatData.Visible = True
        Me.gcrStatData.VisibleIndex = 5
        '
        'gcrIsTurunan
        '
        Me.gcrIsTurunan.Caption = "IsTurunan"
        Me.gcrIsTurunan.FieldName = "isturunan"
        Me.gcrIsTurunan.Name = "gcrIsTurunan"
        '
        'gcrTurunan
        '
        Me.gcrTurunan.AppearanceHeader.Options.UseTextOptions = True
        Me.gcrTurunan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcrTurunan.Caption = "Turunan"
        Me.gcrTurunan.FieldName = "turunan"
        Me.gcrTurunan.Name = "gcrTurunan"
        Me.gcrTurunan.OptionsColumn.AllowEdit = False
        Me.gcrTurunan.OptionsColumn.ReadOnly = True
        Me.gcrTurunan.Visible = True
        Me.gcrTurunan.VisibleIndex = 4
        '
        'tlpRekening
        '
        Me.tlpRekening.AutoSize = True
        Me.tlpRekening.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpRekening.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpRekening.ColumnCount = 4
        Me.tlpRekening.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRekening.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tlpRekening.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440.0!))
        Me.tlpRekening.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRekening.Controls.Add(Me.lueStruktur, 2, 1)
        Me.tlpRekening.Controls.Add(Me.Label1, 1, 1)
        Me.tlpRekening.Controls.Add(Me.lueKodeRekening, 2, 2)
        Me.tlpRekening.Controls.Add(Me.Label4, 1, 2)
        Me.tlpRekening.Controls.Add(Me.Label2, 1, 3)
        Me.tlpRekening.Controls.Add(Me.lueRekening, 2, 3)
        Me.tlpRekening.Controls.Add(Me.Label3, 1, 4)
        Me.tlpRekening.Controls.Add(Me.lueFaktor, 2, 4)
        Me.tlpRekening.Controls.Add(Me.lueRTurunan, 2, 5)
        Me.tlpRekening.Controls.Add(Me.Label14, 1, 5)
        Me.tlpRekening.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpRekening.Location = New System.Drawing.Point(0, 0)
        Me.tlpRekening.Name = "tlpRekening"
        Me.tlpRekening.RowCount = 7
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpRekening.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpRekening.Size = New System.Drawing.Size(706, 132)
        Me.tlpRekening.TabIndex = 9
        '
        'lueStruktur
        '
        Me.lueStruktur.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueStruktur.Location = New System.Drawing.Point(218, 8)
        Me.lueStruktur.Margin = New System.Windows.Forms.Padding(0)
        Me.lueStruktur.Name = "lueStruktur"
        Me.lueStruktur.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueStruktur.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueStruktur.Properties.Appearance.Options.UseBackColor = True
        Me.lueStruktur.Properties.Appearance.Options.UseFont = True
        Me.lueStruktur.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueStruktur.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueStruktur.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idstrukturlaporanneraca", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("strukturlaporanneraca", "Struktur Lap. Neraca")})
        Me.lueStruktur.Properties.NullText = "[Isian belum dipilih]"
        Me.lueStruktur.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueStruktur.Size = New System.Drawing.Size(287, 20)
        Me.lueStruktur.TabIndex = 29
        Me.lueStruktur.Tag = "idstrukturlaporanneraca"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Induk Struktur Lap. Neraca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueKodeRekening
        '
        Me.lueKodeRekening.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueKodeRekening.Location = New System.Drawing.Point(218, 32)
        Me.lueKodeRekening.Margin = New System.Windows.Forms.Padding(0)
        Me.lueKodeRekening.Name = "lueKodeRekening"
        Me.lueKodeRekening.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueKodeRekening.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueKodeRekening.Properties.Appearance.Options.UseBackColor = True
        Me.lueKodeRekening.Properties.Appearance.Options.UseFont = True
        Me.lueKodeRekening.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueKodeRekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueKodeRekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcontent", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Kode Rekening")})
        Me.lueKodeRekening.Properties.NullText = "[Isian belum dipilih]"
        Me.lueKodeRekening.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueKodeRekening.Size = New System.Drawing.Size(213, 20)
        Me.lueKodeRekening.TabIndex = 31
        Me.lueKodeRekening.Tag = "idcoa"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Kode Rekening"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rekening"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueRekening
        '
        Me.lueRekening.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRekening.Location = New System.Drawing.Point(218, 56)
        Me.lueRekening.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRekening.Name = "lueRekening"
        Me.lueRekening.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRekening.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRekening.Properties.Appearance.Options.UseBackColor = True
        Me.lueRekening.Properties.Appearance.Options.UseFont = True
        Me.lueRekening.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRekening.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRekening.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcontent", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Rekening")})
        Me.lueRekening.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRekening.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueRekening.Size = New System.Drawing.Size(440, 20)
        Me.lueRekening.TabIndex = 30
        Me.lueRekening.Tag = "idcoa"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Faktor Lap. Neraca"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lueFaktor
        '
        Me.lueFaktor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueFaktor.Location = New System.Drawing.Point(218, 80)
        Me.lueFaktor.Margin = New System.Windows.Forms.Padding(0)
        Me.lueFaktor.Name = "lueFaktor"
        Me.lueFaktor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueFaktor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueFaktor.Properties.Appearance.Options.UseBackColor = True
        Me.lueFaktor.Properties.Appearance.Options.UseFont = True
        Me.lueFaktor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueFaktor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFaktor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcontent", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Faktor")})
        Me.lueFaktor.Properties.NullText = "[Isian belum dipilih]"
        Me.lueFaktor.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueFaktor.Size = New System.Drawing.Size(150, 20)
        Me.lueFaktor.TabIndex = 30
        Me.lueFaktor.Tag = "faktoraruskas"
        '
        'lueRTurunan
        '
        Me.lueRTurunan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueRTurunan.Location = New System.Drawing.Point(218, 104)
        Me.lueRTurunan.Margin = New System.Windows.Forms.Padding(0)
        Me.lueRTurunan.Name = "lueRTurunan"
        Me.lueRTurunan.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueRTurunan.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueRTurunan.Properties.Appearance.Options.UseBackColor = True
        Me.lueRTurunan.Properties.Appearance.Options.UseFont = True
        Me.lueRTurunan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueRTurunan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueRTurunan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idcontent", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Turunan")})
        Me.lueRTurunan.Properties.NullText = "[Isian belum dipilih]"
        Me.lueRTurunan.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueRTurunan.Size = New System.Drawing.Size(173, 20)
        Me.lueRTurunan.TabIndex = 33
        Me.lueRTurunan.Tag = "isturunan"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(117, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 14)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Beserta Turunan"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'xtpStruktur
        '
        Me.xtpStruktur.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpStruktur.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpStruktur.Controls.Add(Me.pStruktur)
        Me.xtpStruktur.Name = "xtpStruktur"
        Me.xtpStruktur.Size = New System.Drawing.Size(706, 342)
        Me.xtpStruktur.Text = "STRUKTUR"
        '
        'pStruktur
        '
        Me.pStruktur.AutoScroll = True
        Me.pStruktur.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pStruktur.Controls.Add(Me.gcData)
        Me.pStruktur.Controls.Add(Me.tlpData)
        Me.pStruktur.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pStruktur.Location = New System.Drawing.Point(0, 0)
        Me.pStruktur.Name = "pStruktur"
        Me.pStruktur.Size = New System.Drawing.Size(706, 342)
        Me.pStruktur.TabIndex = 1
        '
        'tlpData
        '
        Me.tlpData.AutoSize = True
        Me.tlpData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpData.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tlpData.ColumnCount = 4
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440.0!))
        Me.tlpData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpData.Controls.Add(Me.lueStrukturPeriode, 2, 1)
        Me.tlpData.Controls.Add(Me.Label6, 1, 1)
        Me.tlpData.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpData.Location = New System.Drawing.Point(0, 0)
        Me.tlpData.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpData.Name = "tlpData"
        Me.tlpData.RowCount = 3
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.tlpData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpData.Size = New System.Drawing.Size(706, 36)
        Me.tlpData.TabIndex = 9
        '
        'lueStrukturPeriode
        '
        Me.lueStrukturPeriode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lueStrukturPeriode.Location = New System.Drawing.Point(203, 8)
        Me.lueStrukturPeriode.Margin = New System.Windows.Forms.Padding(0)
        Me.lueStrukturPeriode.Name = "lueStrukturPeriode"
        Me.lueStrukturPeriode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lueStrukturPeriode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lueStrukturPeriode.Properties.Appearance.Options.UseBackColor = True
        Me.lueStrukturPeriode.Properties.Appearance.Options.UseFont = True
        Me.lueStrukturPeriode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lueStrukturPeriode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueStrukturPeriode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("content", "Content")})
        Me.lueStrukturPeriode.Properties.NullText = "[Isian belum dipilih]"
        Me.lueStrukturPeriode.Properties.NullValuePrompt = "[Isian belum dipilih]"
        Me.lueStrukturPeriode.Size = New System.Drawing.Size(172, 20)
        Me.lueStrukturPeriode.TabIndex = 30
        Me.lueStrukturPeriode.Tag = "idstrukturlaporanneracatahun"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 14)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Periode Tahun"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.btnPeriode)
        Me.pHeader.Controls.Add(Me.btnRekening)
        Me.pHeader.Controls.Add(Me.btnStruktur)
        Me.pHeader.Controls.Add(Me.btnSave)
        Me.pHeader.Controls.Add(Me.btnDelete)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(786, 30)
        Me.pHeader.TabIndex = 4
        '
        'btnPeriode
        '
        Me.btnPeriode.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPeriode.FlatAppearance.BorderSize = 0
        Me.btnPeriode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnPeriode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnPeriode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeriode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriode.Location = New System.Drawing.Point(240, 0)
        Me.btnPeriode.Name = "btnPeriode"
        Me.btnPeriode.Size = New System.Drawing.Size(120, 30)
        Me.btnPeriode.TabIndex = 20
        Me.btnPeriode.Text = "INPUT PERIODE"
        Me.btnPeriode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPeriode.UseVisualStyleBackColor = True
        '
        'btnRekening
        '
        Me.btnRekening.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRekening.FlatAppearance.BorderSize = 0
        Me.btnRekening.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRekening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRekening.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRekening.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRekening.Location = New System.Drawing.Point(120, 0)
        Me.btnRekening.Name = "btnRekening"
        Me.btnRekening.Size = New System.Drawing.Size(120, 30)
        Me.btnRekening.TabIndex = 18
        Me.btnRekening.Text = "INPUT REKENING"
        Me.btnRekening.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRekening.UseVisualStyleBackColor = True
        '
        'btnStruktur
        '
        Me.btnStruktur.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnStruktur.FlatAppearance.BorderSize = 0
        Me.btnStruktur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnStruktur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnStruktur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStruktur.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStruktur.Location = New System.Drawing.Point(0, 0)
        Me.btnStruktur.Name = "btnStruktur"
        Me.btnStruktur.Size = New System.Drawing.Size(120, 30)
        Me.btnStruktur.TabIndex = 17
        Me.btnStruktur.Text = "INPUT STRUKTUR"
        Me.btnStruktur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStruktur.UseVisualStyleBackColor = True
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
        Me.btnSave.Location = New System.Drawing.Point(626, 0)
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
        Me.btnDelete.Location = New System.Drawing.Point(706, 0)
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
        'frmStrukturLaporanNeraca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 408)
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStrukturLaporanNeraca"
        Me.ShowInTaskbar = False
        Me.Text = "Struktur Laporan Neraca"
        CType(Me.gvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpForm.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        CType(Me.pMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcStruktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcStruktur.ResumeLayout(False)
        Me.xtpEntryS.ResumeLayout(False)
        Me.pEntryS.ResumeLayout(False)
        Me.pEntryS.PerformLayout()
        CType(Me.gcStruktur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvStruktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpStruktur.ResumeLayout(False)
        Me.tlpStruktur.PerformLayout()
        CType(Me.lueInputSPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seUrutan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teStruktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpPeriode.ResumeLayout(False)
        Me.xtpPeriode.PerformLayout()
        CType(Me.gcPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPeriode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpPeriode.ResumeLayout(False)
        Me.tlpPeriode.PerformLayout()
        CType(Me.tePeriodeStrukturTahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePeriodeRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpEntryR.ResumeLayout(False)
        Me.pEntryR.ResumeLayout(False)
        Me.pEntryR.PerformLayout()
        CType(Me.gcRekening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRekening, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpRekening.ResumeLayout(False)
        Me.tlpRekening.PerformLayout()
        CType(Me.lueStruktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueKodeRekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRekening.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueFaktor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueRTurunan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpStruktur.ResumeLayout(False)
        Me.pStruktur.ResumeLayout(False)
        Me.pStruktur.PerformLayout()
        Me.tlpData.ResumeLayout(False)
        Me.tlpData.PerformLayout()
        CType(Me.lueStrukturPeriode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSep5 As System.Windows.Forms.Label
    Public WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnStruktur As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents pBody As System.Windows.Forms.Panel
    Public WithEvents gcData As DevExpress.XtraGrid.GridControl
    Public WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents tlpStruktur As System.Windows.Forms.TableLayoutPanel
    Public WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gcID As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblStruktur As System.Windows.Forms.Label
    Friend WithEvents gcSK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIDStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pMaximize As System.Windows.Forms.PictureBox
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents teStruktur As DevExpress.XtraEditors.TextEdit
    Public WithEvents tlpRekening As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btnRekening As System.Windows.Forms.Button
    Friend WithEvents lueFaktor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueRekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueStruktur As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gvDetil As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gdtID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtIDparent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtFaktorArusKas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtFaktor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtStatusData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueKodeRekening As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents seUrutan As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents gcUrutan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtcStruktur As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpEntryS As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEntryS As System.Windows.Forms.Panel
    Public WithEvents gcStruktur As DevExpress.XtraGrid.GridControl
    Public WithEvents gvStruktur As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcsID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsIDStat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsNomorUrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsStrukturArusKas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcsStatusData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpEntryR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEntryR As System.Windows.Forms.Panel
    Friend WithEvents xtpStruktur As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pStruktur As System.Windows.Forms.Panel
    Public WithEvents gcRekening As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRekening As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcrID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrIDparent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrIDCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrKodeRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrRekening As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrFaktor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrFaktorArusKas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrStatusData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrStatData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtIsTurunan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gdtTurunan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrIsTurunan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcrTurunan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lueRTurunan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents tlpData As TableLayoutPanel
    Friend WithEvents lueStrukturPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents lueInputSPeriode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents xtpPeriode As DevExpress.XtraTab.XtraTabPage
    Public WithEvents tlpPeriode As TableLayoutPanel
    Friend WithEvents tePeriodeStrukturTahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents tePeriodeRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As Label
    Public WithEvents gcPeriode As DevExpress.XtraGrid.GridControl
    Public WithEvents gvPeriode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents btnPeriode As Button
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
