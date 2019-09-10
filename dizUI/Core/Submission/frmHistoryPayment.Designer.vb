<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoryPayment
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
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.pBody = New System.Windows.Forms.Panel()
        Me.xtcData = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUsage = New DevExpress.XtraTab.XtraTabPage()
        Me.pEntry = New System.Windows.Forms.Panel()
        Me.gcUsage = New DevExpress.XtraGrid.GridControl()
        Me.gvUsage = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcTable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.seNominal = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.xtpHistory = New DevExpress.XtraTab.XtraTabPage()
        Me.gcHistory = New DevExpress.XtraGrid.GridControl()
        Me.gvHistory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcPaymentNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTglBayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAkunbank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.gcKuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcBank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNorek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNamaPengirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.pbSync = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pExit = New System.Windows.Forms.PictureBox()
        Me.tlpForm.SuspendLayout()
        Me.pBody.SuspendLayout()
        CType(Me.xtcData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtcData.SuspendLayout()
        Me.xtpUsage.SuspendLayout()
        Me.pEntry.SuspendLayout()
        CType(Me.gcUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNominal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpHistory.SuspendLayout()
        CType(Me.gcHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pHeader.SuspendLayout()
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTitle.SuspendLayout()
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpForm
        '
        Me.tlpForm.BackColor = System.Drawing.Color.DarkGreen
        Me.tlpForm.ColumnCount = 3
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Controls.Add(Me.pBody, 1, 1)
        Me.tlpForm.Controls.Add(Me.pTitle, 1, 0)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpForm.Location = New System.Drawing.Point(0, 0)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 3
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpForm.Size = New System.Drawing.Size(713, 532)
        Me.tlpForm.TabIndex = 1
        '
        'pBody
        '
        Me.pBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pBody.Controls.Add(Me.xtcData)
        Me.pBody.Controls.Add(Me.pHeader)
        Me.pBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBody.Location = New System.Drawing.Point(2, 30)
        Me.pBody.Margin = New System.Windows.Forms.Padding(0)
        Me.pBody.Name = "pBody"
        Me.pBody.Size = New System.Drawing.Size(709, 500)
        Me.pBody.TabIndex = 7
        '
        'xtcData
        '
        Me.xtcData.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtcData.Appearance.Options.UseBackColor = True
        Me.xtcData.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcData.AppearancePage.Header.Options.UseFont = True
        Me.xtcData.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcData.AppearancePage.HeaderActive.Options.UseFont = True
        Me.xtcData.AppearancePage.HeaderDisabled.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcData.AppearancePage.HeaderDisabled.Options.UseFont = True
        Me.xtcData.AppearancePage.HeaderHotTracked.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcData.AppearancePage.HeaderHotTracked.Options.UseFont = True
        Me.xtcData.AppearancePage.PageClient.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.xtcData.AppearancePage.PageClient.Options.UseFont = True
        Me.xtcData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.xtcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtcData.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtcData.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.xtcData.Location = New System.Drawing.Point(0, 30)
        Me.xtcData.Margin = New System.Windows.Forms.Padding(0)
        Me.xtcData.Name = "xtcData"
        Me.xtcData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.xtcData.SelectedTabPage = Me.xtpUsage
        Me.xtcData.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.xtcData.Size = New System.Drawing.Size(709, 470)
        Me.xtcData.TabIndex = 113
        Me.xtcData.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsage, Me.xtpHistory})
        '
        'xtpUsage
        '
        Me.xtpUsage.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.xtpUsage.Appearance.PageClient.Options.UseBackColor = True
        Me.xtpUsage.Controls.Add(Me.pEntry)
        Me.xtpUsage.Name = "xtpUsage"
        Me.xtpUsage.Size = New System.Drawing.Size(703, 441)
        Me.xtpUsage.Text = "PEMAKAIAN"
        '
        'pEntry
        '
        Me.pEntry.AutoScroll = True
        Me.pEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pEntry.Controls.Add(Me.gcUsage)
        Me.pEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pEntry.Location = New System.Drawing.Point(0, 0)
        Me.pEntry.Name = "pEntry"
        Me.pEntry.Size = New System.Drawing.Size(703, 441)
        Me.pEntry.TabIndex = 0
        '
        'gcUsage
        '
        Me.gcUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUsage.Location = New System.Drawing.Point(0, 0)
        Me.gcUsage.MainView = Me.gvUsage
        Me.gcUsage.Name = "gcUsage"
        Me.gcUsage.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.seNominal})
        Me.gcUsage.Size = New System.Drawing.Size(703, 441)
        Me.gcUsage.TabIndex = 113
        Me.gcUsage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUsage})
        '
        'gvUsage
        '
        Me.gvUsage.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvUsage.Appearance.Empty.Options.UseBackColor = True
        Me.gvUsage.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsage.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvUsage.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvUsage.Appearance.OddRow.Options.UseBackColor = True
        Me.gvUsage.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcTable, Me.gcValue})
        Me.gvUsage.GridControl = Me.gcUsage
        Me.gvUsage.Name = "gvUsage"
        Me.gvUsage.OptionsDetail.ShowDetailTabs = False
        Me.gvUsage.OptionsView.ColumnAutoWidth = False
        Me.gvUsage.OptionsView.EnableAppearanceEvenRow = True
        Me.gvUsage.OptionsView.EnableAppearanceOddRow = True
        Me.gvUsage.OptionsView.ShowFooter = True
        Me.gvUsage.OptionsView.ShowGroupPanel = False
        '
        'gcTable
        '
        Me.gcTable.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTable.Caption = "Nama Tabel"
        Me.gcTable.FieldName = "name"
        Me.gcTable.Name = "gcTable"
        Me.gcTable.OptionsColumn.AllowEdit = False
        Me.gcTable.OptionsColumn.ReadOnly = True
        Me.gcTable.Visible = True
        Me.gcTable.VisibleIndex = 0
        '
        'gcValue
        '
        Me.gcValue.AppearanceHeader.Options.UseTextOptions = True
        Me.gcValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcValue.Caption = "Jml Data"
        Me.gcValue.ColumnEdit = Me.seNominal
        Me.gcValue.DisplayFormat.FormatString = "n0"
        Me.gcValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValue.FieldName = "rowtotal"
        Me.gcValue.Name = "gcValue"
        Me.gcValue.OptionsColumn.AllowEdit = False
        Me.gcValue.OptionsColumn.ReadOnly = True
        Me.gcValue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "rowtotal", "{0:n0}")})
        Me.gcValue.Visible = True
        Me.gcValue.VisibleIndex = 1
        '
        'seNominal
        '
        Me.seNominal.AutoHeight = False
        Me.seNominal.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seNominal.DisplayFormat.FormatString = "n0"
        Me.seNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seNominal.EditFormat.FormatString = "n0"
        Me.seNominal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seNominal.IsFloatValue = False
        Me.seNominal.Mask.EditMask = "N00"
        Me.seNominal.Name = "seNominal"
        Me.seNominal.ReadOnly = True
        '
        'xtpHistory
        '
        Me.xtpHistory.Controls.Add(Me.gcHistory)
        Me.xtpHistory.Name = "xtpHistory"
        Me.xtpHistory.Size = New System.Drawing.Size(703, 441)
        Me.xtpHistory.Text = "PEMBAYARAN"
        '
        'gcHistory
        '
        Me.gcHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcHistory.Location = New System.Drawing.Point(0, 0)
        Me.gcHistory.MainView = Me.gvHistory
        Me.gcHistory.Name = "gcHistory"
        Me.gcHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.gcHistory.Size = New System.Drawing.Size(703, 441)
        Me.gcHistory.TabIndex = 112
        Me.gcHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHistory})
        '
        'gvHistory
        '
        Me.gvHistory.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.gvHistory.Appearance.Empty.Options.UseBackColor = True
        Me.gvHistory.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvHistory.Appearance.EvenRow.Options.UseBackColor = True
        Me.gvHistory.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvHistory.Appearance.OddRow.Options.UseBackColor = True
        Me.gvHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcPaymentNo, Me.gcTglBayar, Me.gcAkunbank, Me.gcNominal, Me.gcKuota, Me.gcBank, Me.gcNorek, Me.gcNamaPengirim, Me.gcValid})
        Me.gvHistory.GridControl = Me.gcHistory
        Me.gvHistory.Name = "gvHistory"
        Me.gvHistory.OptionsDetail.ShowDetailTabs = False
        Me.gvHistory.OptionsView.ColumnAutoWidth = False
        Me.gvHistory.OptionsView.EnableAppearanceEvenRow = True
        Me.gvHistory.OptionsView.EnableAppearanceOddRow = True
        Me.gvHistory.OptionsView.ShowGroupPanel = False
        '
        'gcPaymentNo
        '
        Me.gcPaymentNo.AppearanceHeader.Options.UseTextOptions = True
        Me.gcPaymentNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcPaymentNo.Caption = "No Pembayaran"
        Me.gcPaymentNo.FieldName = "paymentno"
        Me.gcPaymentNo.Name = "gcPaymentNo"
        Me.gcPaymentNo.OptionsColumn.AllowEdit = False
        Me.gcPaymentNo.OptionsColumn.ReadOnly = True
        Me.gcPaymentNo.Visible = True
        Me.gcPaymentNo.VisibleIndex = 0
        '
        'gcTglBayar
        '
        Me.gcTglBayar.AppearanceHeader.Options.UseTextOptions = True
        Me.gcTglBayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcTglBayar.Caption = "Tgl Bayar"
        Me.gcTglBayar.FieldName = "tanggalbayar"
        Me.gcTglBayar.Name = "gcTglBayar"
        Me.gcTglBayar.OptionsColumn.AllowEdit = False
        Me.gcTglBayar.OptionsColumn.ReadOnly = True
        Me.gcTglBayar.Visible = True
        Me.gcTglBayar.VisibleIndex = 4
        '
        'gcAkunbank
        '
        Me.gcAkunbank.AppearanceHeader.Options.UseTextOptions = True
        Me.gcAkunbank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcAkunbank.Caption = "No Rek Tujuan"
        Me.gcAkunbank.FieldName = "akunbank"
        Me.gcAkunbank.Name = "gcAkunbank"
        Me.gcAkunbank.OptionsColumn.AllowEdit = False
        Me.gcAkunbank.OptionsColumn.ReadOnly = True
        Me.gcAkunbank.Visible = True
        Me.gcAkunbank.VisibleIndex = 1
        '
        'gcNominal
        '
        Me.gcNominal.AppearanceCell.Options.UseTextOptions = True
        Me.gcNominal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.gcNominal.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNominal.Caption = "Jml Bayar"
        Me.gcNominal.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.gcNominal.DisplayFormat.FormatString = "n2"
        Me.gcNominal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcNominal.FieldName = "nominalbayar"
        Me.gcNominal.Name = "gcNominal"
        Me.gcNominal.OptionsColumn.AllowEdit = False
        Me.gcNominal.OptionsColumn.ReadOnly = True
        Me.gcNominal.Visible = True
        Me.gcNominal.VisibleIndex = 2
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "n2"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.IsFloatValue = False
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "N00"
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'gcKuota
        '
        Me.gcKuota.AppearanceHeader.Options.UseTextOptions = True
        Me.gcKuota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcKuota.Caption = "Kuota"
        Me.gcKuota.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.gcKuota.DisplayFormat.FormatString = "n0"
        Me.gcKuota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcKuota.FieldName = "nominaldata"
        Me.gcKuota.Name = "gcKuota"
        Me.gcKuota.OptionsColumn.AllowEdit = False
        Me.gcKuota.OptionsColumn.ReadOnly = True
        Me.gcKuota.Visible = True
        Me.gcKuota.VisibleIndex = 3
        '
        'gcBank
        '
        Me.gcBank.AppearanceHeader.Options.UseTextOptions = True
        Me.gcBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcBank.Caption = "Bank Pengirim"
        Me.gcBank.FieldName = "bankpengirim"
        Me.gcBank.Name = "gcBank"
        Me.gcBank.OptionsColumn.AllowEdit = False
        Me.gcBank.OptionsColumn.ReadOnly = True
        Me.gcBank.Visible = True
        Me.gcBank.VisibleIndex = 5
        '
        'gcNorek
        '
        Me.gcNorek.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNorek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNorek.Caption = "No Rek Pengirim"
        Me.gcNorek.FieldName = "norekpengirim"
        Me.gcNorek.Name = "gcNorek"
        Me.gcNorek.OptionsColumn.AllowEdit = False
        Me.gcNorek.OptionsColumn.ReadOnly = True
        Me.gcNorek.Visible = True
        Me.gcNorek.VisibleIndex = 6
        '
        'gcNamaPengirim
        '
        Me.gcNamaPengirim.AppearanceHeader.Options.UseTextOptions = True
        Me.gcNamaPengirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcNamaPengirim.Caption = "a/n Pengirim"
        Me.gcNamaPengirim.FieldName = "atasnamapengirim"
        Me.gcNamaPengirim.Name = "gcNamaPengirim"
        Me.gcNamaPengirim.OptionsColumn.AllowEdit = False
        Me.gcNamaPengirim.OptionsColumn.ReadOnly = True
        Me.gcNamaPengirim.Visible = True
        Me.gcNamaPengirim.VisibleIndex = 7
        '
        'gcValid
        '
        Me.gcValid.AppearanceHeader.Options.UseTextOptions = True
        Me.gcValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gcValid.Caption = "Validasi"
        Me.gcValid.FieldName = "isvalid"
        Me.gcValid.Name = "gcValid"
        Me.gcValid.OptionsColumn.AllowEdit = False
        Me.gcValid.OptionsColumn.ReadOnly = True
        Me.gcValid.Visible = True
        Me.gcValid.VisibleIndex = 8
        '
        'pHeader
        '
        Me.pHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.pHeader.Controls.Add(Me.pbSync)
        Me.pHeader.Controls.Add(Me.btnRefresh)
        Me.pHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pHeader.ForeColor = System.Drawing.Color.White
        Me.pHeader.Location = New System.Drawing.Point(0, 0)
        Me.pHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(709, 30)
        Me.pHeader.TabIndex = 111
        '
        'pbSync
        '
        Me.pbSync.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbSync.Image = Global.dizUI.My.Resources.Resources.loading
        Me.pbSync.Location = New System.Drawing.Point(0, 0)
        Me.pbSync.Name = "pbSync"
        Me.pbSync.Size = New System.Drawing.Size(30, 30)
        Me.pbSync.TabIndex = 28
        Me.pbSync.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Green
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(609, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 30)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.Controls.Add(Me.lblTitle)
        Me.pTitle.Controls.Add(Me.pExit)
        Me.pTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTitle.Location = New System.Drawing.Point(2, 0)
        Me.pTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(709, 30)
        Me.pTitle.TabIndex = 8
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(679, 30)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "History Pembayaran"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pExit
        '
        Me.pExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.pExit.Image = Global.dizUI.My.Resources.Resources.exit_w
        Me.pExit.Location = New System.Drawing.Point(679, 0)
        Me.pExit.Margin = New System.Windows.Forms.Padding(0)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(30, 30)
        Me.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pExit.TabIndex = 11
        Me.pExit.TabStop = False
        '
        'frmHistoryPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistoryPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Pembayaran"
        Me.tlpForm.ResumeLayout(False)
        Me.pBody.ResumeLayout(False)
        CType(Me.xtcData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtcData.ResumeLayout(False)
        Me.xtpUsage.ResumeLayout(False)
        Me.pEntry.ResumeLayout(False)
        CType(Me.gcUsage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUsage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNominal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpHistory.ResumeLayout(False)
        CType(Me.gcHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pHeader.ResumeLayout(False)
        CType(Me.pbSync, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTitle.ResumeLayout(False)
        CType(Me.pExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpForm As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pBody As System.Windows.Forms.Panel
    Friend WithEvents pHeader As System.Windows.Forms.Panel
    Public WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pTitle As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.PictureBox
    Friend WithEvents pbSync As System.Windows.Forms.PictureBox
    Public WithEvents gcHistory As DevExpress.XtraGrid.GridControl
    Public WithEvents gvHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcPaymentNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTglBayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAkunbank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcKuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcBank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNorek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNamaPengirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtcData As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pEntry As System.Windows.Forms.Panel
    Public WithEvents gcUsage As DevExpress.XtraGrid.GridControl
    Public WithEvents gvUsage As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcTable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents xtpHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents seNominal As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
